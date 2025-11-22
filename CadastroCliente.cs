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
    public partial class CadastroCliente : Form
    {
        private static CadastroCliente? _instance;
        public CadastroCliente()
        {
            InitializeComponent();
        }
        #region SingleTon

        public static CadastroCliente GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastroCliente();
            }
            return _instance;
        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskTelefone.Focus();
                mskTelefone.SelectAll();
            }
        }
        private void mskTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.Focus();
            }
        }

        private void Save()
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            if
                (
                    txtNome.Text.Trim() == ""
                    || txtEmail.Text.Trim() == ""
                    || mskTelefone.Text.Trim() == "()-"
                )
            {
                lblAvisoVazio.Visible = true;
                return;
            }
            string email = txtEmail.Text.Trim();
            if (ClienteRepository.ExistsByEmail(email))
            {
                lblAvisoEmail.Visible = true;
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }
            Cliente novoCliente = new Cliente()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = mskTelefone.Text
            };
            ClienteRepository.SaveOrUpdate(novoCliente);

            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();

            txtNome.Focus();

            lblAvisoSucesso.Visible = true;
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblAvisoEmail.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoSucesso.Visible = false;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblAvisoEmail.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoSucesso.Visible = false;
        }
        private void mskTelefone_TextChanged(object sender, EventArgs e)
        {
            lblAvisoEmail.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoSucesso.Visible = false;
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            lblAvisoEmail.Visible = false;
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}