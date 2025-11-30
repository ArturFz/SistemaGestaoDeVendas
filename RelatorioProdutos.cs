using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public partial class RelatorioProdutos : Form
    {
        private static RelatorioProdutos _instance;
        private List<Produto> _produtos;
        private List<Categoria> _categorias;
        public RelatorioProdutos()
        {
            InitializeComponent();

            cboProdutos.Items.Add("Todos");
            cboProdutos.Items.Add("Estoque mínimo alcançado");
            cboProdutos.SelectedIndex = 0;

            _categorias = CategoriaRepository.FindAll();
            cboCategoria.DataSource = _categorias;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = -1;

            numPreco.Minimum = 0;
            numPreco.Maximum = 1000000; // ajusta conforme necessário
            numEstoque.Minimum = 0;
            numEstoque.Maximum = 100000;

            lstRelatorioProdutos.ClearSelected();

            CarregarProdutos();


        }
        public static RelatorioProdutos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioProdutos();
            }
            return _instance;
        }
        private void CarregarProdutos()
        {
            _produtos = ProdutoRepository.FindAllWithCategoria();
            lstRelatorioProdutos.DataSource = _produtos;
            lstRelatorioProdutos.DisplayMember = "Nome";
            lstRelatorioProdutos.ClearSelected();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdutos.SelectedIndex == 0)
            {
                CarregarProdutos();
            }
            else if (cboProdutos.SelectedIndex == 1)
            {
                lstRelatorioProdutos.DataSource = ProdutoRepository.FindByEstoqueMinimo();
                lstRelatorioProdutos.DataSource = _produtos;
                lstRelatorioProdutos.DisplayMember = "Nome";
                lstRelatorioProdutos.ClearSelected();
            }
        }

        private void lstRelatorioProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = lstRelatorioProdutos.SelectedItem as Produto;

            if (produto != null)
            {
                // Preenche campos do produto
                txtNome.Text = produto.Nome;
                numPreco.Value = Math.Min(produto.Preco, numPreco.Maximum);
                numEstoque.Value = Math.Min(produto.Estoque, numEstoque.Maximum);
                chkAtivo.Checked = produto.Ativo;

                // Seleciona categoria automaticamente no ComboBox
                cboCategoria.SelectedValue = produto.Categoria.Id;
            }
            else
            {
                // Nenhum produto selecionado → limpa campos
                txtNome.Clear();
                numPreco.Value = numPreco.Minimum;
                numEstoque.Value = numEstoque.Minimum;
                chkAtivo.Checked = false;
                cboCategoria.SelectedIndex = -1;
            }
        }
    }
}
