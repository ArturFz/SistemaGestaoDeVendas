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
            lblTitulo = new Label();
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
            pnlCadastroCliente.Size = new Size(483, 550);
            pnlCadastroCliente.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(51, 186);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 44);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Cadastre um novo cliente";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(20, 263);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(441, 43);
            txtNome.TabIndex = 22;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(20, 235);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome:";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.icons8_add_user_male_100;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(123, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(237, 171);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 35;
            picLogo.TabStop = false;
            // 
            // lblAvisoSucesso
            // 
            lblAvisoSucesso.AutoSize = true;
            lblAvisoSucesso.BackColor = Color.Transparent;
            lblAvisoSucesso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoSucesso.ForeColor = Color.Green;
            lblAvisoSucesso.Location = new Point(20, 511);
            lblAvisoSucesso.Name = "lblAvisoSucesso";
            lblAvisoSucesso.Size = new Size(266, 21);
            lblAvisoSucesso.TabIndex = 33;
            lblAvisoSucesso.Text = "Cliente cadastrado com sucesso!!!";
            lblAvisoSucesso.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(20, 309);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 25);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(292, 482);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 50);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblAvisoEmail
            // 
            lblAvisoEmail.AutoSize = true;
            lblAvisoEmail.BackColor = Color.Transparent;
            lblAvisoEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoEmail.ForeColor = Color.Red;
            lblAvisoEmail.Location = new Point(20, 489);
            lblAvisoEmail.Name = "lblAvisoEmail";
            lblAvisoEmail.Size = new Size(258, 21);
            lblAvisoEmail.TabIndex = 32;
            lblAvisoEmail.Text = "Endereço de email já existente!!!";
            lblAvisoEmail.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.DarkGray;
            txtEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(20, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 43);
            txtEmail.TabIndex = 21;
            txtEmail.TextChanged += txtEmail_TextChanged_1;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblAvisoVazio
            // 
            lblAvisoVazio.AutoSize = true;
            lblAvisoVazio.BackColor = Color.Transparent;
            lblAvisoVazio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoVazio.ForeColor = Color.Red;
            lblAvisoVazio.Location = new Point(20, 468);
            lblAvisoVazio.Name = "lblAvisoVazio";
            lblAvisoVazio.Size = new Size(251, 21);
            lblAvisoVazio.TabIndex = 31;
            lblAvisoVazio.Text = "Os campos estão incompletos!!!";
            lblAvisoVazio.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(20, 383);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(87, 25);
            lblTelefone.TabIndex = 25;
            lblTelefone.Text = "Telefone:";
            lblTelefone.Click += lblTelefone_Click;
            // 
            // mskTelefone
            // 
            mskTelefone.BackColor = Color.DarkGray;
            mskTelefone.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefone.Location = new Point(20, 411);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(441, 43);
            mskTelefone.TabIndex = 30;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 551);
            Controls.Add(pnlCadastroCliente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
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