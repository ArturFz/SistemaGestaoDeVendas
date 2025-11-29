namespace Trabalho1_ProgVis
{
    public partial class CadastroFuncionario : Form
    {
        private static CadastroFuncionario? _instance;
        private CadastroFuncionario()
        {
            InitializeComponent();
            cboPerfil.SelectedIndex = 2;
        }

        #region SingleTon
        public static CadastroFuncionario GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastroFuncionario();
            }

            return _instance;
        }
        #endregion



        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomeUsuario.Focus();
                txtNomeUsuario.SelectAll();
            }
        }

        private void txtNomeUsuario_KeyUp(object sender, KeyEventArgs e)
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
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;
        }

        private void mskTelefone_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;
        }

        private Perfil GetSelectedPerfilFromCombo()
        {
            return cboPerfil.SelectedIndex switch
            {
                0 => Perfil.GERENTE,
                1 => Perfil.VENDEDOR,
                2 => Perfil.OPERADOR_CAIXA
            };
        }

        private void Save()
        {
            lblAvisoSucesso.Visible = false;
            lblAvisoVazio.Visible = false;
            lblAvisoUsuario.Visible = false;

            if
                (
                    txtNome.Text.Trim() == ""
                    || txtNomeUsuario.Text.Trim() == ""
                    || txtEmail.Text.Trim() == ""
                    || mskTelefone.Text.Trim() == "()-"
                    || txtSenha.Text.Trim() == ""
                )
            {
                lblAvisoVazio.Visible = true;
                return;


            }

            foreach (Credencial c in CredencialRepository.FindAll())
            {
                if (c.NomeUsuario == txtNomeUsuario.Text)
                {
                    lblAvisoUsuario.Visible = true;
                    txtNomeUsuario.Focus();
                    txtNomeUsuario.SelectAll();

                    return;
                }
            }
            Perfil perfilSelecionado = GetSelectedPerfilFromCombo();
            Credencial novaCredencial = new Credencial()
            {
                NomeUsuario = txtNomeUsuario.Text,
                Senha = txtSenha.Text,
                Perfil = perfilSelecionado
            };

            Usuario novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = mskTelefone.Text,
                Credencial = novaCredencial,
                Perfil = perfilSelecionado
            };

            UsuarioRepository.SaveOrUpdate(novoUsuario);

            txtNome.Clear();
            txtNomeUsuario.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            txtSenha.Clear();

            txtNome.Focus();


            lblAvisoSucesso.Visible = true;
        }


        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void lblAvisoSucesso_Click(object sender, EventArgs e)
        {

        }

        private void lblAvisoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
