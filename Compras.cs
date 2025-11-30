using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public partial class Compras : Form
    {
        private Compra compra;
        private static Compras _instance;
        public Compras()
        {
            InitializeComponent();
            ConfigurarGrade();
            numQuantidadeParcelas.Minimum = 1;
        }

        #region SingleTon

        public static Compras GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Compras();
            }
            return _instance;
        }
        #endregion


        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            compra.Cliente = cboClientes.SelectedItem as Cliente;
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = ClienteRepository.FindAll();
            cboClientes.DataSource = clientes;
            cboClientes.DisplayMember = "Nome";
            cboClientes.ValueMember = "Id";
            cboClientes.SelectedIndex = -1;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            compra = new Compra();
            CarregarClientes();
            CarregarCategorias();
            if (cboCategorias.SelectedValue != null)
            {
                CarregarProdutosPorCategoriaSelecionada();
            }
            txtValorParcela.Text = "R$ 0,00";
        }
        private void CarregarProdutosPorCategoriaSelecionada()
        {
            if (cboCategorias.SelectedItem == null)
            {
                return;
            }

            var categoriaId = (cboCategorias.SelectedItem as Categoria)?.Id ?? 0;

            if (categoriaId == 0)
            {
                return;
            }

            List<Produto> produtos = ProdutoRepository.FindByCategoria(categoriaId);

            cboProdutos.DataSource = produtos;
            cboProdutos.DisplayMember = "Nome";
            cboProdutos.ValueMember = "Id";
            cboProdutos.SelectedIndex = -1;  //
        }
        private void CarregarCategorias()
        {
            List<Categoria> categoria = CategoriaRepository.FindAll();
            cboCategorias.DataSource = categoria;
            cboCategorias.DisplayMember = "Nome";
            cboCategorias.ValueMember = "Id";
            cboCategorias.SelectedIndex = -1;
        }
        private void ConfigurarGrade()
        {
            lsvItens.Columns.Add("Código:", 60);
            lsvItens.Columns.Add("Nome:", 225);
            lsvItens.Columns.Add("Categoria:", 150);
            lsvItens.Columns.Add("Quantidade:", 100);
            lsvItens.Columns.Add("Preço (R$):", 80);
            lsvItens.Columns.Add("SubTotal (R$):", 100);

            lsvItens.View = View.Details;
            lsvItens.FullRowSelect = true;
            lsvItens.GridLines = true;
            lsvItens.MultiSelect = false;
        }
        private void AtualizarGrade()
        {
            lsvItens.Items.Clear();

            foreach (var item in compra.Itens)
            {
                ListViewItem linha = new ListViewItem(new string[]
                {
            item.Produto.Id.ToString(),
            item.Produto.Nome,
            item.Produto.Categoria?.Nome ?? "Sem Categoria",
            item.Quantidade.ToString(),
            item.PrecoUnitario.ToString("C2"),
            item.CalcularTotal().ToString("C2")
                });

                linha.Tag = item;
                lsvItens.Items.Add(linha);
            }
        }
        private void AtualizarTotalCompra()
        {
            Decimal totalCompra = compra.CalcularTotal();
            Decimal comissaoVendedor = compra.CalcularComissao();
            lblValorTotal.Text = compra.CalcularTotal().ToString("C2");
            lblComissaoTotal.Text = comissaoVendedor.ToString("C2");
        }
        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarProdutosPorCategoriaSelecionada();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = cboProdutos.SelectedItem as Produto;
            var quantidade = (int)numQuantidade.Value;
            var desconto = numDesconto.Value;

            if (produtoSelecionado != null && quantidade > 0)
            {
                // Validações do desconto
                if (desconto < 0 || desconto > 100)
                {
                    MessageBox.Show("Desconto deve estar entre 0 e 100 (percentual).", "Desconto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (desconto > 5m)
                {
                    // Aqui você pode abrir um diálogo de autorização do gerente.
                    MessageBox.Show("Desconto superior a 5% requer autorização do gerente.", "Autorização necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Item novoItem = new Item
                {
                    Produto = produtoSelecionado,
                    Quantidade = (UInt32)quantidade,
                    Desconto = desconto
                };

                compra.AdicionarItem(novoItem);

                ListViewItem itemListView = new ListViewItem(new string[]
                {
            novoItem.Produto.Id.ToString(),
            novoItem.Produto.Nome,
            novoItem.Produto.Categoria != null ? novoItem.Produto.Categoria.Nome : "Sem Categoria",
            novoItem.Quantidade.ToString(),
            novoItem.PrecoUnitario.ToString("C2"),
            novoItem.CalcularTotal().ToString("C2")
                });

                itemListView.Tag = novoItem;
                lsvItens.Items.Add(itemListView);
                AtualizarValorParcela();
                AtualizarGrade();
                AtualizarTotalCompra();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto e uma quantidade válida.");
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (lsvItens.SelectedItems.Count > 0)
            {
                var itemSelecionado = lsvItens.SelectedItems[0].Tag as Item;

                if (itemSelecionado != null)
                {
                    compra.RemoverItem(itemSelecionado);

                    lsvItens.Items.Remove(lsvItens.SelectedItems[0]);

                    AtualizarValorParcela();
                    AtualizarGrade();
                    AtualizarTotalCompra();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotalCompra();
            AtualizarGrade();
        }

        private void numDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValorParcela();
            AtualizarTotalCompra();
            AtualizarGrade();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            string usuario = txtNomeUsuario.Text;
            string senha = txtSenha.Text;

            var gerente = UsuarioRepository.FindByNome(usuario);
            if (gerente != null && gerente.Credencial.Senha == Credencial.ComputeSHA256(senha, Credencial.SALT))
            {
                // Usuário autorizado
                pnlAutorizacaoGerente.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private Boolean travar = false;
        private const int digitoMax = 8;
        private void txtValorParcela_TextChanged(object sender, EventArgs e)
        {
            if (travar) return;

            travar = true;

            TextBox t = (TextBox)sender;

            String numeros = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");

            if (numeros.Length > digitoMax)
            {
                numeros = numeros.Substring(0, digitoMax);
            }

            if (numeros.Length == 0)
            {
                numeros = "0";
            }

            Decimal valor = Decimal.Parse(numeros) / 100m;

            t.Text = valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));

            t.SelectionStart = t.Text.Length;

            travar = false;
        }
        private void AtualizarValorParcela()
        {
            if (compra == null)
                return; // evita NullReferenceException

            if (compra.Itens == null || compra.Itens.Count == 0)
            {
                txtValorParcela.Text = "R$ 0,00";
                return;
            }

            int parcelas = (int)numQuantidadeParcelas.Value;
            if (parcelas == 0) parcelas = 1;

            decimal totalCompra = compra.CalcularTotal();
            decimal valorParcela = totalCompra / parcelas;

            if (valorParcela < 50m)
            {
                MessageBox.Show("O valor de cada parcela não pode ser menor que R$ 50,00!");
                txtValorParcela.Text = "R$ 0,00";
                return;
            }

            txtValorParcela.Text = valorParcela.ToString("C2", new CultureInfo("pt-BR"));
        }

        private void numQuantidadeParcelas_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValorParcela();
        }
    }
}
