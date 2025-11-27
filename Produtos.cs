using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public partial class Produtos : Form
    {
        private static Produtos? _instance;
        private static Produto? _produtoAtualizar = null;
        public Produtos()
        {
            InitializeComponent();
        }

        #region DataSource Produto
        private BindingList<Produto>? ProdutosSalvos;
        public void UpdateProdutosSalvos()
        {
            List<Produto> lista = ProdutoRepository.FindAll();
            if (ProdutosSalvos == null)
            {
                ProdutosSalvos = new BindingList<Produto>();
            }
            ProdutosSalvos.Clear();

            foreach (Produto novoproduto in lista)
            {
                ProdutosSalvos.Add(novoproduto);
            }
            // Atualiza a fonte de dados do ListBox
            lstProdutos.DataSource = ProdutosSalvos;
            lstProdutos.DisplayMember = "Nome";

            // Garante que nenhum item fique selecionado
            lstProdutos.SelectedIndex = -1;
        }

        public BindingList<Produto>? GetProdutosSalvos()
        {
            UpdateProdutosSalvos();

            return ProdutosSalvos;
        }

        #endregion

        #region SingleTon

        public static Produtos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Produtos();
            }
            return _instance;
        }
        #endregion


        #region Corrigir depois
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            UpdateProdutosSalvos();    // chama aqui para preencher a lista ao abrir
            if (ProdutosSalvos != null)
            {
                lstProdutos.DataSource = ProdutosSalvos;
                lstProdutos.DisplayMember = "Nome";
                lstProdutos.SelectedIndex = -1;
            }
            txtPreco.Text = "R$ 0,00";
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void CarregarCategorias()
        {
            List<Categoria> categorias = CategoriaRepository.FindAll();
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = -1; // Nenhuma selecionada
        }


        private Boolean travar = false;

        private const int digitoMax = 8;
        private void txtPreco_TextChanged(object sender, EventArgs e)
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


        private void Salvar()
        {
            // Validação básica do nome
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                //MessageBox.Show("Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            string nomeTrim = txtNome.Text.Trim();

            // Verifica duplicata uma vez
            var todos = ProdutoRepository.FindAll();
            bool existe = todos.Any(p => string.Equals(p.Nome?.Trim(), nomeTrim, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                //MessageBox.Show("Já existe um produto com esse nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Clear();
                txtNome.Focus();
                return;
            }

            // Cria e salva o produto apenas uma vez
            Produto novoProduto = new Produto()
            {
                Nome = nomeTrim,
                Categoria = (Categoria)cboCategoria.SelectedItem,
                Estoque = (UInt32)numEstoque.Value,
                EstoqueMinimo = (UInt32)numEstoqueMinimo.Value,
                Preco = ParsePreco(txtPreco.Text.Trim()),
                Ativo = chkAtivo.Checked
            };

            ProdutoRepository.SaveOrUpdate(novoProduto);

            // Atualiza UI / lista
            UpdateProdutosSalvos();
            if (ProdutosSalvos != null)
            {
                lstProdutos.DataSource = ProdutosSalvos;
                lstProdutos.DisplayMember = "Nome";
            }

            // Limpa/ajusta campos para próximo cadastro
            txtNome.Clear();
            txtPreco.Text = "R$ 0,00";
            numEstoque.Value = numEstoque.Minimum;
            numEstoqueMinimo.Value = numEstoqueMinimo.Minimum;
            chkAtivo.Checked = true;
        }

        private decimal ParsePreco(String input)
        {
            if (String.IsNullOrWhiteSpace(input)) return 0m;

            String s = input.Trim()
                            .Replace("R$", "", StringComparison.OrdinalIgnoreCase)
                            .Replace("$", "")
                            .Replace(" ", "");

            var pt = CultureInfo.GetCultureInfo("pt-BR");
            if (Decimal.TryParse(s, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, pt, out var valor))
                return valor;

            // Se falhar, devolve 0 (mantém comportamento simples). Você pode validar e mostrar erro ao usuário se preferir.
            return 0m;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
            txtNome.Clear();
            txtPreco.Clear();
            numEstoque.Value = numEstoque.Minimum;
            numEstoqueMinimo.Value = numEstoqueMinimo.Minimum;
            cboCategoria.SelectedIndex = -1;
            chkAtivo.Checked = false;
            txtNome.Focus();
        }

        private void numEstoqueMinimo_ValueChanged(object sender, EventArgs e)
        {
            numEstoque.Minimum = numEstoqueMinimo.Value;
        }

        private void pnlProdutos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
