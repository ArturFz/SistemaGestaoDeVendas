namespace Trabalho1_ProgVis
{
    partial class CadastroFuncionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            pnlCadastroFuncionario = new Panel();
            lblPerfil = new Label();
            cboPerfil = new ComboBox();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblAvisoSucesso = new Label();
            lblAvisoUsuario = new Label();
            lblAvisoVazio = new Label();
            mskTelefone = new MaskedTextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            pnlCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastroFuncionario
            // 
            pnlCadastroFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroFuncionario.Controls.Add(lblPerfil);
            pnlCadastroFuncionario.Controls.Add(cboPerfil);
            pnlCadastroFuncionario.Controls.Add(picLogo);
            pnlCadastroFuncionario.Controls.Add(lblTitulo);
            pnlCadastroFuncionario.Controls.Add(lblAvisoSucesso);
            pnlCadastroFuncionario.Controls.Add(lblAvisoUsuario);
            pnlCadastroFuncionario.Controls.Add(lblAvisoVazio);
            pnlCadastroFuncionario.Controls.Add(mskTelefone);
            pnlCadastroFuncionario.Controls.Add(lblSenha);
            pnlCadastroFuncionario.Controls.Add(txtSenha);
            pnlCadastroFuncionario.Controls.Add(lblNomeUsuario);
            pnlCadastroFuncionario.Controls.Add(txtNomeUsuario);
            pnlCadastroFuncionario.Controls.Add(lblTelefone);
            pnlCadastroFuncionario.Controls.Add(lblEmail);
            pnlCadastroFuncionario.Controls.Add(lblNome);
            pnlCadastroFuncionario.Controls.Add(txtNome);
            pnlCadastroFuncionario.Controls.Add(txtEmail);
            pnlCadastroFuncionario.Controls.Add(btnCadastrar);
            pnlCadastroFuncionario.Location = new Point(4, 3);
            pnlCadastroFuncionario.Name = "pnlCadastroFuncionario";
            pnlCadastroFuncionario.Size = new Size(498, 637);
            pnlCadastroFuncionario.TabIndex = 0;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(8, 508);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(37, 15);
            lblPerfil.TabIndex = 19;
            lblPerfil.Text = "Perfil:";
            // 
            // cboPerfil
            // 
            cboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPerfil.FormattingEnabled = true;
            cboPerfil.Items.AddRange(new object[] { "Gerente", "Vendedor", "Operador de Caixa" });
            cboPerfil.Location = new Point(8, 523);
            cboPerfil.Name = "cboPerfil";
            cboPerfil.Size = new Size(185, 33);
            cboPerfil.TabIndex = 18;
            // 
            // picLogo
            // 
            picLogo.Image = Trabalho_TCD.Properties.Resources.SAA__1__removebg_preview;
            picLogo.Location = new Point(143, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(194, 153);
            picLogo.TabIndex = 17;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(19, 188);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(456, 44);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Cadastre um novo funcionário";
            // 
            // lblAvisoSucesso
            // 
            lblAvisoSucesso.AutoSize = true;
            lblAvisoSucesso.BackColor = Color.Green;
            lblAvisoSucesso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoSucesso.ForeColor = SystemColors.ControlLightLight;
            lblAvisoSucesso.Location = new Point(8, 611);
            lblAvisoSucesso.Name = "lblAvisoSucesso";
            lblAvisoSucesso.Size = new Size(202, 20);
            lblAvisoSucesso.TabIndex = 15;
            lblAvisoSucesso.Text = "Usuário criado com sucesso";
            lblAvisoSucesso.Visible = false;
            // 
            // lblAvisoUsuario
            // 
            lblAvisoUsuario.AutoSize = true;
            lblAvisoUsuario.BackColor = Color.Yellow;
            lblAvisoUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoUsuario.ForeColor = Color.Red;
            lblAvisoUsuario.Location = new Point(8, 591);
            lblAvisoUsuario.Name = "lblAvisoUsuario";
            lblAvisoUsuario.Size = new Size(215, 20);
            lblAvisoUsuario.TabIndex = 14;
            lblAvisoUsuario.Text = "Nome de Usuário já existente";
            lblAvisoUsuario.Visible = false;
            // 
            // lblAvisoVazio
            // 
            lblAvisoVazio.AutoSize = true;
            lblAvisoVazio.BackColor = Color.Yellow;
            lblAvisoVazio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoVazio.ForeColor = Color.Red;
            lblAvisoVazio.Location = new Point(8, 571);
            lblAvisoVazio.Name = "lblAvisoVazio";
            lblAvisoVazio.Size = new Size(217, 20);
            lblAvisoVazio.TabIndex = 13;
            lblAvisoVazio.Text = "Os campos estão incompletos";
            lblAvisoVazio.Visible = false;
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14F);
            mskTelefone.Location = new Point(8, 421);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(478, 32);
            mskTelefone.TabIndex = 12;
            mskTelefone.TextChanged += mskTelefone_TextChanged;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 454);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(8, 472);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(478, 33);
            txtSenha.TabIndex = 9;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(8, 295);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(102, 15);
            lblNomeUsuario.TabIndex = 8;
            lblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(8, 313);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(478, 33);
            txtNomeUsuario.TabIndex = 7;
            txtNomeUsuario.TextChanged += txtNomeUsuario_TextChanged;
            txtNomeUsuario.KeyUp += txtNomeUsuario_KeyUp;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(8, 403);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 349);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(8, 241);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(8, 259);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(478, 33);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(8, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(478, 33);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(317, 588);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 43);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 641);
            Controls.Add(pnlCadastroFuncionario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            pnlCadastroFuncionario.ResumeLayout(false);
            pnlCadastroFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroFuncionario;
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private MaskedTextBox mskTelefone;
        private Label lblAvisoVazio;
        private Label lblAvisoUsuario;
        private Label lblAvisoSucesso;
        private Label lblTitulo;
        private PictureBox picLogo;
        private ComboBox cboPerfil;
        private Label lblPerfil;
    }
}
