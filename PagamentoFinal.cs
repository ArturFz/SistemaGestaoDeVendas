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


            // controles do designer: txtValorParcelas = valor parcela, txtValorTotal = valor total, txtEstado = estado
            txtValorParcelas.Clear();
            txtValorTotal.Clear();
            txtEstado.Clear();
        }

        // Método público para receber parcelas calculadas em Vendas
        // Exemplo de uso em Vendas:
        //   var janela = PagamentoFinal.GetInstance();
        //   janela.PreencherParcelas(compra.Pagamentos, compra);
        //   janela.ShowDialog(this);
        public void PreencherParcelas(IEnumerable<Pagamento> parcelas, Compra? compra = null)
        {
            _parcelaSelecionada = null;
            _compraSelecionada = compra;

            var lista = (parcelas ?? Enumerable.Empty<Pagamento>()).ToList();

            decimal valorPadraoPorParcela = 0m;
            if (compra != null && lista.Count > 0)
            {
                valorPadraoPorParcela = Math.Round(compra.CalcularTotal() / lista.Count, 2, MidpointRounding.AwayFromZero);
            }
            else if (lista.Count > 0)
            {
                valorPadraoPorParcela = lista.Sum(p =>
                {
                    try
                    {
                        dynamic d = p;
                        return (decimal)d.Valor;
                    }
                    catch
                    {
                        return 0m;
                    }
                }) / lista.Count;
            }

            foreach (var p in lista)
            {
                decimal valorParcela;
                try
                {
                    dynamic d = p;
                    valorParcela = (decimal)d.Valor;
                }
                catch
                {
                    valorParcela = valorPadraoPorParcela;
                }

                bool pago = false;
                try
                {
                    dynamic d = p;
                    if (d.DataPagamento is DateTime?)
                        pago = ((DateTime?)d.DataPagamento).HasValue;
                    else
                        pago = ((DateTime)d.DataPagamento) != default(DateTime);
                }
                catch
                {
                    pago = false;
                }

                string status = pago ? GetPagamentoStatusString(p) : "Em aberto";
                string display = $"{p.Vencimento:dd/MM/yyyy} - {valorParcela.ToString("C2")} - {status}";
            }

            decimal total = 0m;
            if (compra != null)
            {
                total = compra.CalcularTotal();
                txtValorTotal.Text = total.ToString("C2");
                txtEstado.Text = ObterEstadoPagamento(compra);
            }
            else
            {
                total = lista.Sum(p =>
                {
                    try
                    {
                        dynamic d = p;
                        return (decimal)d.Valor;
                    }
                    catch
                    {
                        return valorPadraoPorParcela;
                    }
                });
                txtValorTotal.Text = total.ToString("C2");

                int totalP = lista.Count;
                int pagos = lista.Count(p =>
                {
                    try
                    {
                        dynamic d = p;
                        if (d.DataPagamento is DateTime?)
                            return ((DateTime?)d.DataPagamento).HasValue;
                        else
                            return ((DateTime)d.DataPagamento) != default(DateTime);
                    }
                    catch { return false; }
                });
                txtEstado.Text = totalP == 0 ? "Sem parcelas" : (pagos == 0 ? "Em aberto" : (pagos == totalP ? "Quitado" : "Parcial"));
            }

            if (lista.Count > 0)
            {
                var primeiro = lista.First();
                decimal primeiroValor;
                try
                {
                    dynamic d = primeiro;
                    primeiroValor = (decimal)d.Valor;
                }
                catch
                {
                    primeiroValor = valorPadraoPorParcela;
                }
                txtValorParcelas.Text = primeiroValor.ToString("C2");
            }
            else
            {
                txtValorParcelas.Text = 0m.ToString("C2");
            }
        }

        private string GetPagamentoStatusString(Pagamento p)
        {
            try
            {
                dynamic d = p;
                if (d.DataPagamento is DateTime?)
                {
                    var dt = (DateTime?)d.DataPagamento;
                    return dt.HasValue ? $"Pago {dt.Value:dd/MM/yyyy}" : "Em aberto";
                }
                else
                {
                    var dt = (DateTime)d.DataPagamento;
                    return dt != default(DateTime) ? $"Pago {dt:dd/MM/yyyy}" : "Em aberto";
                }
            }
            catch
            {
                return "Em aberto";
            }
        }

        private void CboClientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstCompras.Items.Clear();
            txtValorParcelas.Clear();
            txtValorTotal.Clear();
            txtEstado.Clear();
            _compraSelecionada = null;
            _parcelaSelecionada = null;

            var cliente = cboClientes.SelectedItem as Cliente;
            if (cliente == null) return;

            using (Repository db = new Repository())
            {
                var comprasTodos = db.Compras
                    .Include(c => c.Cliente)
                    .Include(c => c.Pagamentos)
                    .Include(c => c.Itens)
                        .ThenInclude(i => i.Produto)
                    .ToList();

                var compras = comprasTodos
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
            txtValorParcelas.Clear();
            txtValorTotal.Clear();
            txtEstado.Clear();
            _compraSelecionada = null;
            _parcelaSelecionada = null;

            if (lstCompras.SelectedItem is ListBoxItem<Compra> item)
            {
                // primeiro tenta usar o objeto Compra que já está no ListBox (ele já vem com Pagamentos se foi carregado via CboClientes)
                var compraDoItem = item.Value;
                if (compraDoItem != null && compraDoItem.Pagamentos != null && compraDoItem.Pagamentos.Count > 0)
                {
                    _compraSelecionada = compraDoItem;
                    PreencherParcelas(compraDoItem.Pagamentos, compraDoItem);
                    return;
                }

                // fallback: consulta o banco incluindo Pagamentos
                using (Repository db = new Repository())
                {
                    var compra = db.Compras
                        .Include(c => c.Pagamentos)
                        .Include(c => c.Itens)
                            .ThenInclude(i => i.Produto)
                        .FirstOrDefault(c => c.Id == item.Value.Id);

                    if (compra == null) return;

                    _compraSelecionada = compra;
                    PreencherParcelas(compra.Pagamentos ?? Enumerable.Empty<Pagamento>(), compra);
                }
            }
        }

        private void LstParcelas_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void BtnFinalizarPagamento_Click(object? sender, EventArgs e)
        {
            // precisa ter uma compra selecionada na lista
            if (_compraSelecionada == null)
            {
                MessageBox.Show("Selecione uma compra para pagar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UInt64 compraId = _compraSelecionada.Id;

                using (Repository db = new Repository())
                {
                    // carrega a compra com pagamentos
                    var compraDb = db.Compras
                        .Include(c => c.Pagamentos)
                        .Include(c => c.Itens)
                            .ThenInclude(i => i.Produto)
                        .FirstOrDefault(c => c.Id == compraId);

                    if (compraDb == null)
                    {
                        MessageBox.Show("Compra não encontrada no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool marcouAlguma = false;

                    // Se houver parcelas, marca as não pagas como pagas
                    if (compraDb.Pagamentos != null && compraDb.Pagamentos.Count > 0)
                    {
                        foreach (var p in compraDb.Pagamentos)
                        {
                            // compatível com DataPagamento nullable ou não
                            var prop = p.GetType().GetProperty("DataPagamento");
                            if (prop != null)
                            {
                                var val = prop.GetValue(p);
                                if (val == null)
                                {
                                    prop.SetValue(p, DateTime.Now);
                                    marcouAlguma = true;
                                }
                                else if (val is DateTime dt && dt == default(DateTime))
                                {
                                    prop.SetValue(p, DateTime.Now);
                                    marcouAlguma = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Não há parcelas: cria uma parcela representando o pagamento à vista e já marca como paga
                        var novaParcela = new Pagamento()
                        {
                            Vencimento = DateTime.Now,
                            DataPagamento = DateTime.Now,
                            MultaAtraso = 0m
                        };

                        if (compraDb.Pagamentos == null)
                            compraDb.Pagamentos = new List<Pagamento>();

                        compraDb.Pagamentos.Add(novaParcela);
                        marcouAlguma = true;
                    }

                    if (!marcouAlguma)
                    {
                        MessageBox.Show("Todos os pagamentos já estão quitados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega a compra e atualiza a UI (parcelas / status / valor)
                using (Repository db = new Repository())
                {
                    var compraAtualizada = db.Compras
                        .Include(c => c.Pagamentos)
                        .Include(c => c.Itens)
                            .ThenInclude(i => i.Produto)
                        .FirstOrDefault(c => c.Id == _compraSelecionada.Id);

                    if (compraAtualizada != null)
                    {
                        _compraSelecionada = compraAtualizada;
                        PreencherParcelas(compraAtualizada.Pagamentos ?? Enumerable.Empty<Pagamento>(), compraAtualizada);
                    }
                    else
                    {
                        // limpa UI se compra não encontrada
                        txtValorParcelas.Text = "R$ 0,00";
                        txtValorTotal.Text = "R$ 0,00";
                        txtEstado.Text = "Sem parcelas";
                    }
                }

                _parcelaSelecionada = null;
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
            int pagos = compra.Pagamentos.Count(p =>
            {
                try
                {
                    dynamic d = p;
                    if (d.DataPagamento is DateTime?)
                        return ((DateTime?)d.DataPagamento).HasValue;
                    else
                        return ((DateTime)d.DataPagamento) != default(DateTime);
                }
                catch { return false; }
            });

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
