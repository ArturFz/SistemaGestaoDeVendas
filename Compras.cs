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
    public partial class Compras : Form
    {
        private static Compras _instance;
        public Compras()
        {
            InitializeComponent();
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
            CarregarClientes();
        }

        private void cboClientes_DropDown(object sender, EventArgs e)
        {

        }
    }
}
