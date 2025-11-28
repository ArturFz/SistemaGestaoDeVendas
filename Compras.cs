using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
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
            cboClientes.DropDown += cboClientes_DropDown;
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
        }

        private void cboClientes_DropDown(object sender, EventArgs e)
        {

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

            foreach (Produto p in ProdutoRepository.FindAllWithCategoria())
            {

                decimal subtotal = p.Preco * p.Estoque;

                ListViewItem item = new ListViewItem(new string[] {
            p.Id.ToString(),
            p.Nome,
            p.Categoria != null ? p.Categoria.Nome : "Sem Categoria",
            p.Estoque.ToString(),
            p.Preco.ToString("C2"),
            subtotal.ToString("C2")
        });

                item.Tag = p;

                lsvItens.Items.Add(item);
                lblValorTotal.Text = compra.CalcularTotal().ToString("C2");
            }
        }
        private void AtualizarTotalCompra()
        {
            Decimal totalCompra = compra.CalcularTotal();

            Decimal comissaoVendedor = compra.CalcularComissao();
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
            novoItem.Produto.Categoria != null ? novoItem.Produto.Categoria.Nome : "Sem Categoria", // Categoria
            novoItem.Quantidade.ToString(), 
            novoItem.Produto.Preco.ToString("C2"),
            novoItem.CalcularTotal().ToString("C2")
                });

                itemListView.Tag = novoItem;
                lsvItens.Items.Add(itemListView);
                lblValorTotal.Text = compra.CalcularTotal().ToString("C2");

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
        }

        private void numDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotalCompra();
        }
        private void Compras_Resize(object sender, EventArgs e)
        {

        }
    }
}
