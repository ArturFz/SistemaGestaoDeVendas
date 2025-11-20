namespace Trabalho_TCD
{
    partial class CadastroCliente
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
            pnlCadastroCliente = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblAvisoSucesso = new Label();
            lblEmail = new Label();
            btnCadastrar = new Button();
            lblAvisoUsuario = new Label();
            txtEmail = new TextBox();
            lblAvisoVazio = new Label();
            lblTelefone = new Label();
            mskTelefone = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            pnlCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCliente.Controls.Add(picLogo);
            pnlCadastroCliente.Controls.Add(lblTitulo);
            pnlCadastroCliente.Controls.Add(lblAvisoSucesso);
            pnlCadastroCliente.Controls.Add(lblEmail);
            pnlCadastroCliente.Controls.Add(btnCadastrar);
            pnlCadastroCliente.Controls.Add(lblAvisoUsuario);
            pnlCadastroCliente.Controls.Add(txtEmail);
            pnlCadastroCliente.Controls.Add(lblAvisoVazio);
            pnlCadastroCliente.Controls.Add(lblTelefone);
            pnlCadastroCliente.Controls.Add(mskTelefone);
            pnlCadastroCliente.Location = new Point(0, 0);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(516, 482);
            pnlCadastroCliente.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.IconeNAvendas2;
            picLogo.InitialImage = Properties.Resources.IconeNAvendas;
            picLogo.Location = new Point(194, 26);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(139, 133);
            picLogo.TabIndex = 35;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(69, 185);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 44);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Cadastre um novo cliente";
            // 
            // lblAvisoSucesso
            // 
            lblAvisoSucesso.AutoSize = true;
            lblAvisoSucesso.BackColor = Color.Green;
            lblAvisoSucesso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoSucesso.ForeColor = SystemColors.ControlLightLight;
            lblAvisoSucesso.Location = new Point(20, 449);
            lblAvisoSucesso.Name = "lblAvisoSucesso";
            lblAvisoSucesso.Size = new Size(202, 20);
            lblAvisoSucesso.TabIndex = 33;
            lblAvisoSucesso.Text = "Usuário criado com sucesso";
            lblAvisoSucesso.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 293);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(329, 429);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 43);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblAvisoUsuario
            // 
            lblAvisoUsuario.AutoSize = true;
            lblAvisoUsuario.BackColor = Color.Yellow;
            lblAvisoUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoUsuario.ForeColor = Color.Red;
            lblAvisoUsuario.Location = new Point(20, 429);
            lblAvisoUsuario.Name = "lblAvisoUsuario";
            lblAvisoUsuario.Size = new Size(215, 20);
            lblAvisoUsuario.TabIndex = 32;
            lblAvisoUsuario.Text = "Nome de Usuário já existente";
            lblAvisoUsuario.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(20, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(478, 33);
            txtEmail.TabIndex = 21;
            // 
            // lblAvisoVazio
            // 
            lblAvisoVazio.AutoSize = true;
            lblAvisoVazio.BackColor = Color.Yellow;
            lblAvisoVazio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoVazio.ForeColor = Color.Red;
            lblAvisoVazio.Location = new Point(20, 409);
            lblAvisoVazio.Name = "lblAvisoVazio";
            lblAvisoVazio.Size = new Size(217, 20);
            lblAvisoVazio.TabIndex = 31;
            lblAvisoVazio.Text = "Os campos estão incompletos";
            lblAvisoVazio.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 347);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 25;
            lblTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14F);
            mskTelefone.Location = new Point(20, 365);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(478, 32);
            mskTelefone.TabIndex = 30;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 239);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(20, 257);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(478, 33);
            txtNome.TabIndex = 22;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 483);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(pnlCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCadastroCliente;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Label lblAvisoSucesso;
        private Label lblAvisoUsuario;
        private Label lblAvisoVazio;
        private MaskedTextBox mskTelefone;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnCadastrar;
    }
}