namespace Trabalho_TCD
{
    partial class Produtos
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
            pnlProdutos = new Panel();
            numEstoqueMinimo = new NumericUpDown();
            label1 = new Label();
            lblCategoria = new Label();
            lstCategorias = new ListBox();
            chkAtivo = new CheckBox();
            lblEstoqueMinimo = new Label();
            lblEstoque = new Label();
            txtEstoque = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            btnCadastrar = new Button();
            lstProdutos = new ListBox();
            lblNome = new Label();
            lblTitulo = new Label();
            txtNome = new TextBox();
            pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // pnlProdutos
            // 
            pnlProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProdutos.Controls.Add(numEstoqueMinimo);
            pnlProdutos.Controls.Add(label1);
            pnlProdutos.Controls.Add(lblCategoria);
            pnlProdutos.Controls.Add(lstCategorias);
            pnlProdutos.Controls.Add(chkAtivo);
            pnlProdutos.Controls.Add(lblEstoqueMinimo);
            pnlProdutos.Controls.Add(lblEstoque);
            pnlProdutos.Controls.Add(txtEstoque);
            pnlProdutos.Controls.Add(lblPreco);
            pnlProdutos.Controls.Add(txtPreco);
            pnlProdutos.Controls.Add(btnCadastrar);
            pnlProdutos.Controls.Add(lstProdutos);
            pnlProdutos.Controls.Add(lblNome);
            pnlProdutos.Controls.Add(lblTitulo);
            pnlProdutos.Controls.Add(txtNome);
            pnlProdutos.Location = new Point(4, 3);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(846, 766);
            pnlProdutos.TabIndex = 1;
            // 
            // numEstoqueMinimo
            // 
            numEstoqueMinimo.BackColor = Color.DarkGray;
            numEstoqueMinimo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoqueMinimo.Location = new Point(601, 337);
            numEstoqueMinimo.Name = "numEstoqueMinimo";
            numEstoqueMinimo.Size = new Size(237, 39);
            numEstoqueMinimo.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 48;
            label1.Text = "Lista de produtos:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(601, 414);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(98, 25);
            lblCategoria.TabIndex = 47;
            lblCategoria.Text = "Categoria:";
            lblCategoria.Click += lblCategoria_Click;
            // 
            // lstCategorias
            // 
            lstCategorias.BackColor = Color.DarkGray;
            lstCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCategorias.FormattingEnabled = true;
            lstCategorias.ItemHeight = 25;
            lstCategorias.Location = new Point(601, 442);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(237, 254);
            lstCategorias.TabIndex = 46;
            lstCategorias.Tag = "";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAtivo.Location = new Point(602, 382);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(74, 29);
            chkAtivo.TabIndex = 45;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            chkAtivo.CheckedChanged += chkAtivo_CheckedChanged;
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.AutoSize = true;
            lblEstoqueMinimo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoqueMinimo.Location = new Point(601, 309);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(152, 25);
            lblEstoqueMinimo.TabIndex = 44;
            lblEstoqueMinimo.Text = "Estoque mínimo:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(601, 235);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(83, 25);
            lblEstoque.TabIndex = 42;
            lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            txtEstoque.BackColor = Color.DarkGray;
            txtEstoque.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstoque.Location = new Point(602, 263);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(237, 43);
            txtEstoque.TabIndex = 41;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(602, 161);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(64, 25);
            lblPreco.TabIndex = 40;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.DarkGray;
            txtPreco.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(601, 189);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(237, 43);
            txtPreco.TabIndex = 39;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(601, 702);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(237, 53);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lstProdutos
            // 
            lstProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 25;
            lstProdutos.Location = new Point(8, 55);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(276, 704);
            lstProdutos.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(599, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(627, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 82);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Cadastre um \r\nnovo produto";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(601, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 43);
            txtNome.TabIndex = 1;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 770);
            Controls.Add(pnlProdutos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += Produtos_Load;
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProdutos;
        private Button btnCadastrar;
        private ListBox lstProdutos;
        private Label lblNome;
        private Label lblTitulo;
        private TextBox txtNome;
        private Label lblEstoqueMinimo;
        private Label lblEstoque;
        private TextBox txtEstoque;
        private Label lblPreco;
        private TextBox txtPreco;
        private CheckBox chkAtivo;
        private ListBox lstCategorias;
        private Label lblCategoria;
        private Label label1;
        private NumericUpDown numEstoqueMinimo;
    }
}