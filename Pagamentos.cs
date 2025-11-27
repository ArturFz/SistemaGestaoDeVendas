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
    public partial class Pagamentos : Form
    {
        private static Pagamentos _instance;

        #region SingleTon
        public static Pagamentos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Pagamentos();
            }
            return _instance;
        }
        #endregion
        public Pagamentos()
        {
            InitializeComponent();
            Load += Pagamentos_Load;
            lblAviso.Visible = false;
            cboClientes.DropDown += cboClientes_DropDown;
        }

        private void Pagamentos_Load(object? sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnIniciarPagamento_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex < 0)
            {
                lblAviso.Visible = true;
                return;
            }
            lblAviso.Visible = false;

            Cliente clienteSelecionado = (Cliente)cboClientes.SelectedItem;

            PagamentoFinal janela = PagamentoFinal.GetInstance();
            janela.ShowDialog(this);
            janela.BringToFront();
            janela.Focus();
        }
        private void CarregarClientes()
        {
            List<Cliente> lista = ClienteRepository.FindAll();

            cboClientes.DataSource = lista;
            cboClientes.DisplayMember = "Nome";
            cboClientes.ValueMember = "Id";
            cboClientes.SelectedIndex = -1;
        }

        private void cboClientes_DropDown(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
        }
    }
}
