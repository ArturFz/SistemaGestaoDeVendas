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
    public partial class ListaProdutos : Form
    {
        private static ListaProdutos? _instance;
        public ListaProdutos()
        {
            InitializeComponent();
            AjustarListView();
        }
        public static ListaProdutos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new ListaProdutos();

            return _instance;
        }

        private void AjustarListView()
        {
            lsvListaProdutos.Columns.Add("Código:", 60);
            lsvListaProdutos.Columns.Add("Nome:", 225);
            lsvListaProdutos.Columns.Add("Categoria:", 150);
            lsvListaProdutos.Columns.Add("Preço (R$):", 80);
            lsvListaProdutos.Columns.Add("Estado:", 60);
            lsvListaProdutos.Columns.Add("Estoque:", 80);
            lsvListaProdutos.Columns.Add("Estoque Mínimo:", 110);

            lsvListaProdutos.View = View.Details;
            lsvListaProdutos.FullRowSelect = true;
            lsvListaProdutos.GridLines = true;
            lsvListaProdutos.MultiSelect = false;

            AtualizarListView();
        }

        private void AtualizarListView()
        {
            lsvListaProdutos.Items.Clear();

            foreach (Produto p in ProdutoRepository.FindAllWithCategoria())
            {
                ListViewItem item = new ListViewItem(new string[] {
                    p.Id.ToString(),
                    p.Nome!,
                    p.Categoria != null ? p.Categoria.Nome!.ToString() : "Sem Categoria",
                    p.Preco.ToString("C2"),
                    p.Estoque.ToString(),
                    p.EstoqueMinimo.ToString(),
                    p.Ativo ? "Ativo" : "Inativo"
                });

                item.Tag = p;

                lsvListaProdutos.Items.Add(item);
            }
        }
    }
}