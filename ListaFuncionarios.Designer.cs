namespace Trabalho1_ProgVis
{
    partial class ListaFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFuncionarios));
            pnlListaUsuarios = new Panel();
            lblTitulo = new Label();
            lblUltimoAcessoDefault = new Label();
            lblUltimoAcesso = new Label();
            lblPerfilDefault = new Label();
            lblPerfil = new Label();
            lblTelefoneDefault = new Label();
            lblEmailDefault = new Label();
            lblNomeDefault = new Label();
            lblNomeUsuario = new Label();
            lstFuncionarios = new ListBox();
            lblNome = new Label();
            lblNomeUsuarioDefault = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            pnlListaUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlListaUsuarios
            // 
            pnlListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListaUsuarios.Controls.Add(lblTitulo);
            pnlListaUsuarios.Controls.Add(lblUltimoAcessoDefault);
            pnlListaUsuarios.Controls.Add(lblUltimoAcesso);
            pnlListaUsuarios.Controls.Add(lblPerfilDefault);
            pnlListaUsuarios.Controls.Add(lblPerfil);
            pnlListaUsuarios.Controls.Add(lblTelefoneDefault);
            pnlListaUsuarios.Controls.Add(lblEmailDefault);
            pnlListaUsuarios.Controls.Add(lblNomeDefault);
            pnlListaUsuarios.Controls.Add(lblNomeUsuario);
            pnlListaUsuarios.Controls.Add(lstFuncionarios);
            pnlListaUsuarios.Controls.Add(lblNome);
            pnlListaUsuarios.Controls.Add(lblNomeUsuarioDefault);
            pnlListaUsuarios.Controls.Add(lblEmail);
            pnlListaUsuarios.Controls.Add(lblTelefone);
            pnlListaUsuarios.Location = new Point(12, 12);
            pnlListaUsuarios.Name = "pnlListaUsuarios";
            pnlListaUsuarios.Size = new Size(563, 483);
            pnlListaUsuarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(83, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(393, 53);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "Lista de Funcionários";
            // 
            // lblUltimoAcessoDefault
            // 
            lblUltimoAcessoDefault.AutoSize = true;
            lblUltimoAcessoDefault.BackColor = SystemColors.ControlLightLight;
            lblUltimoAcessoDefault.Font = new Font("Segoe UI", 14F);
            lblUltimoAcessoDefault.Location = new Point(258, 450);
            lblUltimoAcessoDefault.Name = "lblUltimoAcessoDefault";
            lblUltimoAcessoDefault.Size = new Size(283, 25);
            lblUltimoAcessoDefault.TabIndex = 32;
            lblUltimoAcessoDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblUltimoAcesso
            // 
            lblUltimoAcesso.AutoSize = true;
            lblUltimoAcesso.BackColor = SystemColors.ControlDarkDark;
            lblUltimoAcesso.Font = new Font("Segoe UI", 14F);
            lblUltimoAcesso.Location = new Point(258, 425);
            lblUltimoAcesso.Name = "lblUltimoAcesso";
            lblUltimoAcesso.Size = new Size(135, 25);
            lblUltimoAcesso.TabIndex = 31;
            lblUltimoAcesso.Text = "Último Acesso:";
            // 
            // lblPerfilDefault
            // 
            lblPerfilDefault.AutoSize = true;
            lblPerfilDefault.BackColor = SystemColors.ControlLightLight;
            lblPerfilDefault.Font = new Font("Segoe UI", 14F);
            lblPerfilDefault.Location = new Point(258, 376);
            lblPerfilDefault.Name = "lblPerfilDefault";
            lblPerfilDefault.Size = new Size(283, 25);
            lblPerfilDefault.TabIndex = 30;
            lblPerfilDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = SystemColors.ControlDarkDark;
            lblPerfil.Font = new Font("Segoe UI", 14F);
            lblPerfil.Location = new Point(258, 351);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(59, 25);
            lblPerfil.TabIndex = 29;
            lblPerfil.Text = "Perfil:";
            // 
            // lblTelefoneDefault
            // 
            lblTelefoneDefault.AutoSize = true;
            lblTelefoneDefault.BackColor = SystemColors.ControlLightLight;
            lblTelefoneDefault.Font = new Font("Segoe UI", 14F);
            lblTelefoneDefault.Location = new Point(258, 305);
            lblTelefoneDefault.Name = "lblTelefoneDefault";
            lblTelefoneDefault.Size = new Size(283, 25);
            lblTelefoneDefault.TabIndex = 28;
            lblTelefoneDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblEmailDefault
            // 
            lblEmailDefault.AutoSize = true;
            lblEmailDefault.BackColor = SystemColors.ControlLightLight;
            lblEmailDefault.Font = new Font("Segoe UI", 14F);
            lblEmailDefault.Location = new Point(258, 229);
            lblEmailDefault.Name = "lblEmailDefault";
            lblEmailDefault.Size = new Size(283, 25);
            lblEmailDefault.TabIndex = 27;
            lblEmailDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblNomeDefault
            // 
            lblNomeDefault.AutoSize = true;
            lblNomeDefault.BackColor = SystemColors.ControlLightLight;
            lblNomeDefault.Font = new Font("Segoe UI", 14F);
            lblNomeDefault.Location = new Point(258, 97);
            lblNomeDefault.Name = "lblNomeDefault";
            lblNomeDefault.Size = new Size(283, 25);
            lblNomeDefault.TabIndex = 26;
            lblNomeDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = SystemColors.ControlDarkDark;
            lblNomeUsuario.Font = new Font("Segoe UI", 14F);
            lblNomeUsuario.Location = new Point(258, 137);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(168, 25);
            lblNomeUsuario.TabIndex = 25;
            lblNomeUsuario.Text = "Nome de Usuário: ";
            // 
            // lstFuncionarios
            // 
            lstFuncionarios.BackColor = SystemColors.ControlDark;
            lstFuncionarios.Font = new Font("Segoe UI", 14F);
            lstFuncionarios.ForeColor = SystemColors.Window;
            lstFuncionarios.FormattingEnabled = true;
            lstFuncionarios.ItemHeight = 25;
            lstFuncionarios.Location = new Point(11, 72);
            lstFuncionarios.Name = "lstFuncionarios";
            lstFuncionarios.Size = new Size(245, 404);
            lstFuncionarios.TabIndex = 0;
            lstFuncionarios.Tag = "Lista de Usuários";
            lstFuncionarios.Click += lstUsuarios_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ControlDarkDark;
            lblNome.Font = new Font("Segoe UI", 14F);
            lblNome.Location = new Point(258, 72);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome:\r\n";
            // 
            // lblNomeUsuarioDefault
            // 
            lblNomeUsuarioDefault.AutoSize = true;
            lblNomeUsuarioDefault.BackColor = SystemColors.ControlLightLight;
            lblNomeUsuarioDefault.Font = new Font("Segoe UI", 14F);
            lblNomeUsuarioDefault.Location = new Point(258, 162);
            lblNomeUsuarioDefault.Name = "lblNomeUsuarioDefault";
            lblNomeUsuarioDefault.Size = new Size(283, 25);
            lblNomeUsuarioDefault.TabIndex = 19;
            lblNomeUsuarioDefault.Text = "Aguardando Seleção de Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ControlDarkDark;
            lblEmail.Font = new Font("Segoe UI", 14F);
            lblEmail.Location = new Point(258, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 25);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = SystemColors.ControlDarkDark;
            lblTelefone.Font = new Font("Segoe UI", 14F);
            lblTelefone.Location = new Point(258, 280);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(87, 25);
            lblTelefone.TabIndex = 17;
            lblTelefone.Text = "Telefone:";
            // 
            // ListaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 507);
            Controls.Add(pnlListaUsuarios);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Funcionários";
            pnlListaUsuarios.ResumeLayout(false);
            pnlListaUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlListaUsuarios;
        private ListBox lstFuncionarios;
        private TextBox txtNome;
        private Label lblNomeUsuarioDefault;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblNomeUsuario;
        private Label lblNomeDefault;
        private Label lblEmailDefault;
        private Label lblTelefoneDefault;
        private Label lblPerfil;
        private Label lblPerfilDefault;
        private Label lblUltimoAcesso;
        private Label lblUltimoAcessoDefault;
        private Label lblTitulo;
    }
}