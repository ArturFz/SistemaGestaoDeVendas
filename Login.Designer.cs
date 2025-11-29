namespace Trabalho1_ProgVis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            lblAviso = new Label();
            lblSenha = new Label();
            lblNomeUsuario = new Label();
            txtSenha = new TextBox();
            txtNomeUsuario = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAviso);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblNomeUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 379);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Noto Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(368, 43);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "FAÇA SEU LOGIN";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Trabalho_TCD.Properties.Resources._8788070391647100444_128;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(104, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = Color.Transparent;
            lblAviso.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(66, 334);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(224, 30);
            lblAviso.TabIndex = 5;
            lblAviso.Text = "Credenciais Inválidas!!!";
            lblAviso.Visible = false;
            lblAviso.Click += lblAviso_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(31, 261);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 24);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(31, 188);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(147, 24);
            lblNomeUsuario.TabIndex = 3;
            lblNomeUsuario.Text = "Nome de Usuário:";
            lblNomeUsuario.Click += lblNomeUsuario_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.DarkGray;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(31, 288);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(298, 43);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.BackColor = Color.DarkGray;
            txtNomeUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(31, 215);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(298, 43);
            txtNomeUsuario.TabIndex = 1;
            txtNomeUsuario.TextChanged += txtNomeUsuario_TextChanged;
            txtNomeUsuario.KeyUp += txtNomeUsuario_KeyUp;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 382);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtNomeUsuario;
        private Label lblSenha;
        private Label lblNomeUsuario;
        private Label lblAviso;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
}