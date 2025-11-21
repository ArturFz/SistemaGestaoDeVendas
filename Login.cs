using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1_ProgVis
{
    public partial class Login : Form
    {
        private static Login? _instance;

        private Usuario _usuarioInstance;
        public static Login GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Login();
            }

            return _instance;
        }
        public Login()
        {
            InitializeComponent();
        }
        private void txtNomeUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Credencial> _credenciais = new List<Credencial>();
                _credenciais = CredencialRepository.FindAllWithUsuario();

                txtNomeUsuario.Focus();
                txtNomeUsuario.SelectAll();

                foreach (Credencial u in _credenciais)
                {
                    if (u.NomeUsuario == txtNomeUsuario.Text)
                    {
                        if (u.Senha == Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT))
                        {
                            _usuarioInstance = u.Usuario;

                            txtNomeUsuario.Clear();
                            txtSenha.Clear();

                            Hide();

                            Sistema.GetInstance(_usuarioInstance).Show();
                        }
                        else
                        {
                            txtSenha.Clear();
                            lblAviso.Visible = true;
                        }

                        break;
                    }
                }
            }
        }
        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
