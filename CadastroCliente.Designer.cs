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
            txtNome = new TextBox();
            lblNome = new Label();
            picLogo = new PictureBox();
            lblAvisoSucesso = new Label();
            lblEmail = new Label();
            btnCadastrar = new Button();
            lblAvisoEmail = new Label();
            txtEmail = new TextBox();
            lblAvisoVazio = new Label();
            lblTelefone = new Label();
            mskTelefone = new MaskedTextBox();
            lblTitulo = new Label();
            pnlCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCliente.Controls.Add(lblTitulo);
            pnlCadastroCliente.Controls.Add(txtNome);
            pnlCadastroCliente.Controls.Add(lblNome);
            pnlCadastroCliente.Controls.Add(picLogo);
            pnlCadastroCliente.Controls.Add(lblAvisoSucesso);
            pnlCadastroCliente.Controls.Add(lblEmail);
            pnlCadastroCliente.Controls.Add(btnCadastrar);
            pnlCadastroCliente.Controls.Add(lblAvisoEmail);
            pnlCadastroCliente.Controls.Add(txtEmail);
            pnlCadastroCliente.Controls.Add(lblAvisoVazio);
            pnlCadastroCliente.Controls.Add(lblTelefone);
            pnlCadastroCliente.Controls.Add(mskTelefone);
            pnlCadastroCliente.Location = new Point(0, 0);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(516, 473);
            pnlCadastroCliente.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(20, 248);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(478, 33);
            txtNome.TabIndex = 22;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 230);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome:";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.icons8_add_user_male_100;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(136, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(237, 171);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 35;
            picLogo.TabStop = false;
            // 
            // lblAvisoSucesso
            // 
            lblAvisoSucesso.AutoSize = true;
            lblAvisoSucesso.BackColor = Color.Green;
            lblAvisoSucesso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoSucesso.ForeColor = SystemColors.ControlLightLight;
            lblAvisoSucesso.Location = new Point(20, 439);
            lblAvisoSucesso.Name = "lblAvisoSucesso";
            lblAvisoSucesso.Size = new Size(211, 20);
            lblAvisoSucesso.TabIndex = 33;
            lblAvisoSucesso.Text = "Cliente criado com sucesso!!!";
            lblAvisoSucesso.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 284);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(322, 409);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(176, 50);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblAvisoEmail
            // 
            lblAvisoEmail.AutoSize = true;
            lblAvisoEmail.BackColor = Color.Yellow;
            lblAvisoEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoEmail.ForeColor = Color.Red;
            lblAvisoEmail.Location = new Point(20, 419);
            lblAvisoEmail.Name = "lblAvisoEmail";
            lblAvisoEmail.Size = new Size(235, 20);
            lblAvisoEmail.TabIndex = 32;
            lblAvisoEmail.Text = "Endereço de email já existente!!!";
            lblAvisoEmail.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(20, 302);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(478, 33);
            txtEmail.TabIndex = 21;
            txtEmail.TextChanged += txtEmail_TextChanged_1;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblAvisoVazio
            // 
            lblAvisoVazio.AutoSize = true;
            lblAvisoVazio.BackColor = Color.Yellow;
            lblAvisoVazio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoVazio.ForeColor = Color.Red;
            lblAvisoVazio.Location = new Point(20, 399);
            lblAvisoVazio.Name = "lblAvisoVazio";
            lblAvisoVazio.Size = new Size(232, 20);
            lblAvisoVazio.TabIndex = 31;
            lblAvisoVazio.Text = "Os campos estão incompletos!!!";
            lblAvisoVazio.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 338);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 25;
            lblTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14F);
            mskTelefone.Location = new Point(20, 356);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(478, 32);
            mskTelefone.TabIndex = 30;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(65, 186);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 44);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Cadastre um novo cliente";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 474);
            Controls.Add(pnlCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroCliente;
        private Label lblAvisoSucesso;
        private Label lblAvisoEmail;
        private Label lblAvisoVazio;
        private MaskedTextBox mskTelefone;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnCadastrar;
        private PictureBox picLogo;
        private Label lblTitulo;
    }
}