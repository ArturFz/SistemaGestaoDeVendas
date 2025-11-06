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
    public partial class ListaUsuarios : Form
    {
        private static ListaUsuarios? _instance;

        public ListaUsuarios()
        {
            InitializeComponent();

            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioRepository.FindAllWithCredencial();

            lstUsuarios.Items.AddRange(usuarios.ToArray());
        }

        #region SingleTon
        public static ListaUsuarios GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ListaUsuarios();
            }

            return _instance;
        }
        #endregion

        private void lstUsuarios_Click(object sender, EventArgs e)
        {
            Usuario? usuario = (Usuario?)lstUsuarios.SelectedItem;

            if (usuario == null) return;

            //String? perfil = usuario.Credencial.Perfil ? "Gerente" : "Comum";

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
            {
                lblUltimoAcessoDefault.Text = "Usuário não acessou.";
            }
            else
            {
                String ultacess = usuario.Credencial.UltimoAcesso.ToString("dd/MM/yyyy HH:mm");
                lblUltimoAcessoDefault.Text = ultacess;
            }

            lblNomeDefault.Text = usuario.Nome;
            lblNomeUsuarioDefault.Text = usuario.Credencial.NomeUsuario;
            lblEmailDefault.Text = usuario.Email;
            lblTelefoneDefault.Text = usuario.Telefone;
            //lblPerfilDefault.Text = perfil;
        }
    }
}
