namespace Trabalho_TCD
{
    partial class Categorias
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
            pnlCategorias = new Panel();
            lblAvisoCategoriaExistente = new Label();
            lblSucesso = new Label();
            lblAvisoNome = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            lstCategorias = new ListBox();
            lblNome = new Label();
            lblTitulo = new Label();
            txtNome = new TextBox();
            pnlCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCategorias
            // 
            pnlCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCategorias.Controls.Add(lblAvisoCategoriaExistente);
            pnlCategorias.Controls.Add(lblSucesso);
            pnlCategorias.Controls.Add(lblAvisoNome);
            pnlCategorias.Controls.Add(label1);
            pnlCategorias.Controls.Add(btnCadastrar);
            pnlCategorias.Controls.Add(lstCategorias);
            pnlCategorias.Controls.Add(lblNome);
            pnlCategorias.Controls.Add(lblTitulo);
            pnlCategorias.Controls.Add(txtNome);
            pnlCategorias.Location = new Point(-2, 0);
            pnlCategorias.Name = "pnlCategorias";
            pnlCategorias.Size = new Size(751, 471);
            pnlCategorias.TabIndex = 0;
            pnlCategorias.Paint += pnlCategorias_Paint;
            // 
            // lblAvisoCategoriaExistente
            // 
            lblAvisoCategoriaExistente.AutoSize = true;
            lblAvisoCategoriaExistente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoCategoriaExistente.ForeColor = Color.Red;
            lblAvisoCategoriaExistente.Location = new Point(26, 273);
            lblAvisoCategoriaExistente.Name = "lblAvisoCategoriaExistente";
            lblAvisoCategoriaExistente.Size = new Size(200, 21);
            lblAvisoCategoriaExistente.TabIndex = 42;
            lblAvisoCategoriaExistente.Text = "Essa categoria já existe!!!";
            lblAvisoCategoriaExistente.Visible = false;
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucesso.ForeColor = Color.Green;
            lblSucesso.Location = new Point(26, 273);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(285, 21);
            lblSucesso.TabIndex = 41;
            lblSucesso.Text = "Categoria cadastrada com sucesso!!!";
            lblSucesso.Visible = false;
            // 
            // lblAvisoNome
            // 
            lblAvisoNome.AutoSize = true;
            lblAvisoNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoNome.ForeColor = Color.Red;
            lblAvisoNome.Location = new Point(26, 273);
            lblAvisoNome.Name = "lblAvisoNome";
            lblAvisoNome.Size = new Size(362, 21);
            lblAvisoNome.TabIndex = 40;
            lblAvisoNome.Text = "Você deve digitar um nome para a categoria!!!";
            lblAvisoNome.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(403, 71);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 39;
            label1.Text = "CATEGORIAS EXISTENTES";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(19, 182);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(362, 56);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lstCategorias
            // 
            lstCategorias.BackColor = Color.DarkGray;
            lstCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCategorias.FormattingEnabled = true;
            lstCategorias.ItemHeight = 25;
            lstCategorias.Location = new Point(403, 103);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(335, 354);
            lstCategorias.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(19, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(751, 45);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "ADICIONAR NOVA CATEGORIA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click_1;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(19, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 46);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 470);
            Controls.Add(pnlCategorias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de categorias";
            Load += Categorias_Load;
            pnlCategorias.ResumeLayout(false);
            pnlCategorias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategorias;
        private TextBox txtNome;
        private Label lblTitulo;
        private Label lblNome;
        private ListBox lstCategorias;
        private Button btnCadastrar;
        private Label label1;
        private Label lblAvisoCategoriaExistente;
        private Label lblSucesso;
        private Label lblAvisoNome;
    }
}