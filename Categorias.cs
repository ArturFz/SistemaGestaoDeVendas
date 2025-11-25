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
    public partial class Categorias : Form
    {
        private static Categorias? _instance;


        public Categorias()
        {
            InitializeComponent();
            lstCategorias.DataSource = GetCategoriasSalvas();
            lstCategorias.DisplayMember = "Nome";
        }

        #region DataSource Categoria
        private BindingList<Categoria>? CategoriasSalvas;
        public void UpdateCategoriasSalvas()
        {
            List<Categoria> lista = CategoriaRepository.FindAll();

            if (CategoriasSalvas == null)
            {
                CategoriasSalvas = new BindingList<Categoria>();
            }

            CategoriasSalvas.Clear();

            foreach (Categoria c in lista)
            {
                CategoriasSalvas.Add(c);
            }
        }
        public BindingList<Categoria>? GetCategoriasSalvas()
        {
            UpdateCategoriasSalvas();

            return CategoriasSalvas;
        }

        #endregion

        #region SingleTon
        public static Categorias GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Categorias();
            }
            return _instance;
        }
        #endregion

        #region Corrigir_depois
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
            txtNome.Focus();
        }

        public void Salvar()
        {
            if (txtNome.Text.Trim() == "")
            {
                // Colocar mensagem de erro
                return;
            }

            foreach (Categoria ca in CategoriaRepository.FindAll())
            {
                if (ca.Nome.ToLower() == txtNome.Text.Trim().ToLower())
                {
                    // Colocar mensagem de erro
                    txtNome.Focus();
                    return;
                }
            }

            Categoria c = new Categoria(){ Nome = txtNome.Text.Trim()};

            CategoriaRepository.SaveOrUpdate(c);
            UpdateCategoriasSalvas();
        }
    }
}
