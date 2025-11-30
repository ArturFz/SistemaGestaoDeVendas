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
    public partial class RelatorioFuncionarios : Form
    {
        private static RelatorioFuncionarios? _instance;

        public RelatorioFuncionarios()
        {
            InitializeComponent();

            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioRepository.FindAllWithCredencial();

            lstFuncionarios.Items.AddRange(usuarios.ToArray());
        }

        #region SingleTon
        public static RelatorioFuncionarios GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioFuncionarios();
            }

            return _instance;
        }
        #endregion

        private void lstUsuarios_Click(object sender, EventArgs e)
        {
            Usuario? usuario = (Usuario?)lstFuncionarios.SelectedItem;

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
            lblPerfilDefault.Text = usuario.Perfil switch
            {
                Perfil.GERENTE => "Gerente",
                Perfil.VENDEDOR => "Vendedor",
                Perfil.OPERADOR_CAIXA => "Operador de Caixa",
                _ => usuario.Perfil.ToString(),
            };
        }
    }
}
