using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public partial class PagamentoFinal : Form
    {
        private static PagamentoFinal? _instance;

        private Compra? _compraSelecionada;
        private Pagamento? _parcelaSelecionada;

        #region SingleTon
        public static PagamentoFinal GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PagamentoFinal();
            }
            return _instance;
        }
        #endregion

        public PagamentoFinal()
        {
            InitializeComponent();

            // eventos
            Load += PagamentoFinal_Load;
            cboClientes.SelectedIndexChanged += CboClientes_SelectedIndexChanged;
            lstCompras.SelectedIndexChanged += LstCompras_SelectedIndexChanged;
            lstParcelas.SelectedIndexChanged += LstParcelas_SelectedIndexChanged;
            btnFinalizarPagamento.Click += BtnFinalizarPagamento_Click;
        }

        private void PagamentoFinal_Load(object? sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            var clientes = ClienteRepository.FindAll();
            cboClientes.DataSource = clientes;
            cboClientes.DisplayMember = "Nome";
            cboClientes.ValueMember = "Id";
            cboClientes.SelectedIndex = -1;

            // limpa UI
            lstCompras.Items.Clear();
            lstParcelas.Items.Clear();
            txtValorParcelas.Clear(); // valor parcela
            txtValorTotal.Clear(); // valor total
            txtEstado.Clear(); // estado (estado de pagamento)
        }

        private void CboClientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstCompras.Items.Clear();
            lstParcelas.Items.Clear();
            txtValorParcelas.Clear();
            txtValorTotal.Clear();
            txtEstado.Clear();
            _compraSelecionada = null;
            _parcelaSelecionada = null;

            var cliente = cboClientes.SelectedItem as Cliente;
            if (cliente == null) return;

            // busca compras do cliente incluindo pagamentos e itens (com produto) para calcular corretamente o total
            using (Repository db = new Repository())
            {
                var compras = db.Compras
                    .Include(c => c.Cliente)
                    .Include(c => c.Pagamentos)
                    .Include(c => c.Itens)
                        .ThenInclude(i => i.Produto)
                    .Where(c => c.Cliente != null && c.Cliente.Id == cliente.Id)
                    .ToList();

                lstCompras.Items.Clear();
                foreach (var c in compras)
                {
                    string display = $"Nº {c.Numero} - {c.Inicio:dd/MM/yyyy} - {c.CalcularTotal():C2}";
                    lstCompras.Items.Add(new ListBoxItem<Compra>(c, display));
                }
            }
        }

        private void LstCompras_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstParcelas.Items.Clear();
            txtValorParcelas.Clear();
            txtValorTotal.Clear();
            txtEstado.Clear();
            _compraSelecionada = null;
            _parcelaSelecionada = null;

            if (lstCompras.SelectedItem is ListBoxItem<Compra> item)
            {
                // recarrega compra do DB para garantir navegação de pagamentos e itens atualizada
                using (Repository db = new Repository())
                {
                    var compra = db.Compras
                        .Include(c => c.Pagamentos)
                        .Include(c => c.Itens)
                            .ThenInclude(i => i.Produto)
                        .FirstOrDefault(c => c.Id == item.Value.Id);

                    if (compra == null) return;

                    _compraSelecionada = compra;

                    // popula parcelas
                    if (compra.Pagamentos != null && compra.Pagamentos.Count > 0)
                    {
                        foreach (var p in compra.Pagamentos)
                        {
                            string status = (p.DataPagamento == default(DateTime) || p.DataPagamento == DateTime.MinValue) ? "Em aberto" : $"Pago em {p.DataPagamento:dd/MM/yyyy}";
                            string display = $"{p.Vencimento:dd/MM/yyyy} - {status}";
                            lstParcelas.Items.Add(new ListBoxItem<Pagamento>(p, display));
                        }

                        // valor por parcela: cálculo pelo total / quantidade de parcelas (quando não há valor explícito na parcela)
                        decimal valorParcela;
                        if (compra.Pagamentos.All(p => p.MultaAtraso == default)) // heuristic, mantém cálculo simples
                        {
                            valorParcela = compra.CalcularTotal() / compra.Pagamentos.Count;
                        }
                        else
                        {
                            // fallback: divide igualmente
                            valorParcela = compra.CalcularTotal() / compra.Pagamentos.Count;
                        }

                        txtValorParcelas.Text = valorParcela.ToString("C2");
                    }

                    txtValorTotal.Text = compra.CalcularTotal().ToString("C2");

                    // exibe o estado de pagamento da compra (não o estado da compra)
                    txtEstado.Text = ObterEstadoPagamento(compra);
                }
            }
        }

        private void LstParcelas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _parcelaSelecionada = null;
            if (lstParcelas.SelectedItem is ListBoxItem<Pagamento> item)
            {
                _parcelaSelecionada = item.Value;
            }
        }

        private void BtnFinalizarPagamento_Click(object? sender, EventArgs e)
        {
            if (_compraSelecionada == null)
            {
                MessageBox.Show("Selecione uma compra.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_parcelaSelecionada == null)
            {
                MessageBox.Show("Selecione uma parcela para pagar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // verifica se já está quitada
            if (!(_parcelaSelecionada.DataPagamento == default(DateTime) || _parcelaSelecionada.DataPagamento == DateTime.MinValue))
            {
                MessageBox.Show("Parcela já quitada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (Repository db = new Repository())
                {
                    // carrega compra com pagamentos
                    var compraDb = db.Compras
                        .Include(c => c.Pagamentos)
                        .FirstOrDefault(c => c.Id == _compraSelecionada.Id);

                    if (compraDb == null)
                    {
                        MessageBox.Show("Compra não encontrada no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // localiza a parcela dentro da compra carregada
                    var parcelaDb = compraDb.Pagamentos.FirstOrDefault(p => p.Id == _parcelaSelecionada.Id);

                    if (parcelaDb == null)
                    {
                        MessageBox.Show("Parcela não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // marca pagamento
                    parcelaDb.DataPagamento = DateTime.Now;

                    db.SaveChanges();
                }

                MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refresca UI: recarrega compras do cliente selecionado
                CboClientes_SelectedIndexChanged(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar pagamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // calcula o estado de pagamento da compra: "Sem parcelas", "Em aberto", "Parcial", "Quitado"
        private string ObterEstadoPagamento(Compra compra)
        {
            if (compra.Pagamentos == null || compra.Pagamentos.Count == 0)
                return "Sem parcelas";

            int total = compra.Pagamentos.Count;
            int pagos = compra.Pagamentos.Count(p => !(p.DataPagamento == default(DateTime) || p.DataPagamento == DateTime.MinValue));

            if (pagos == 0) return "Em aberto";
            if (pagos == total) return "Quitado";
            return "Parcial";
        }

        // Helper interno para exibir objetos com string customizada no ListBox
        private class ListBoxItem<T>
        {
            public T Value { get; }
            public string Display { get; }

            public ListBoxItem(T value, string display)
            {
                Value = value;
                Display = display;
            }

            public override string ToString() => Display;
        }
    }
}
