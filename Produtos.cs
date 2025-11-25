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
            lstCategorias.DataSource = Categorias.GetInstance().GetCategoriasSalvas();
            lstCategorias.DisplayMember = "Nome";

            txtPreco.Text = "R$ 0,00";



            numEstoqueMinimo.Minimum = 10;
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

            foreach (Produto p in lista)
            {
                ProdutosSalvos.Add(p);
            }
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

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
            txtNome.Focus();
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
            if (txtNome.Text.Trim() == "")
            {
                // Colocar mensagem de erro
                return;
            }

            foreach (Produto produto in ProdutoRepository.FindAll())
            {
                if (produto.Nome.ToLower() == txtNome.Text.Trim().ToLower())
                {
                    // Colocar mensagem de erro
                    txtNome.Clear();
                    txtNome.Focus();
                    return;
                }

                Produto novoProduto = new Produto()
                {
                    Nome = txtNome.Text.Trim(),
                    Categoria = (Categoria)lstCategorias.SelectedItem,
                    Estoque = (UInt32)numEstoque.Value,
                    EstoqueMinimo = (UInt32)numEstoqueMinimo.Value,
                    Preco = ParsePreco(txtPreco.Text.Trim()),
                };
            }
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

    }
}
