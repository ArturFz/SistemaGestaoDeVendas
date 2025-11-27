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
            cboCategoria = new ComboBox();
            numEstoque = new NumericUpDown();
            numEstoqueMinimo = new NumericUpDown();
            lblProdutosExistentes = new Label();
            lblCategoria = new Label();
            chkAtivo = new CheckBox();
            lblEstoqueMinimo = new Label();
            lblEstoque = new Label();
            lblPreco = new Label();
            txtPreco = new TextBox();
            btnCadastrar = new Button();
            lstProdutos = new ListBox();
            lblNome = new Label();
            lblTitulo = new Label();
            txtNome = new TextBox();
            pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // pnlProdutos
            // 
            pnlProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProdutos.Controls.Add(cboCategoria);
            pnlProdutos.Controls.Add(numEstoque);
            pnlProdutos.Controls.Add(numEstoqueMinimo);
            pnlProdutos.Controls.Add(lblProdutosExistentes);
            pnlProdutos.Controls.Add(lblCategoria);
            pnlProdutos.Controls.Add(chkAtivo);
            pnlProdutos.Controls.Add(lblEstoqueMinimo);
            pnlProdutos.Controls.Add(lblEstoque);
            pnlProdutos.Controls.Add(lblPreco);
            pnlProdutos.Controls.Add(txtPreco);
            pnlProdutos.Controls.Add(btnCadastrar);
            pnlProdutos.Controls.Add(lstProdutos);
            pnlProdutos.Controls.Add(lblNome);
            pnlProdutos.Controls.Add(lblTitulo);
            pnlProdutos.Controls.Add(txtNome);
            pnlProdutos.Location = new Point(4, 3);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(708, 530);
            pnlProdutos.TabIndex = 1;
            pnlProdutos.Paint += pnlProdutos_Paint;
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.DarkGray;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(20, 376);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(284, 40);
            cboCategoria.TabIndex = 51;
            // 
            // numEstoque
            // 
            numEstoque.BackColor = Color.DarkGray;
            numEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoque.Location = new Point(19, 236);
            numEstoque.Name = "numEstoque";
            numEstoque.Size = new Size(284, 39);
            numEstoque.TabIndex = 50;
            // 
            // numEstoqueMinimo
            // 
            numEstoqueMinimo.BackColor = Color.DarkGray;
            numEstoqueMinimo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoqueMinimo.Location = new Point(20, 306);
            numEstoqueMinimo.Name = "numEstoqueMinimo";
            numEstoqueMinimo.Size = new Size(284, 39);
            numEstoqueMinimo.TabIndex = 49;
            numEstoqueMinimo.ValueChanged += numEstoqueMinimo_ValueChanged;
            // 
            // lblProdutosExistentes
            // 
            lblProdutosExistentes.AutoSize = true;
            lblProdutosExistentes.Font = new Font("Noto Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdutosExistentes.ForeColor = SystemColors.ControlDarkDark;
            lblProdutosExistentes.Location = new Point(418, 56);
            lblProdutosExistentes.Name = "lblProdutosExistentes";
            lblProdutosExistentes.Size = new Size(231, 29);
            lblProdutosExistentes.TabIndex = 48;
            lblProdutosExistentes.Text = "PRODUTOS EXISTENTES";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(20, 348);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(98, 25);
            lblCategoria.TabIndex = 47;
            lblCategoria.Text = "Categoria:";
            lblCategoria.Click += lblCategoria_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAtivo.Location = new Point(20, 422);
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
            lblEstoqueMinimo.Location = new Point(19, 278);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(152, 25);
            lblEstoqueMinimo.TabIndex = 44;
            lblEstoqueMinimo.Text = "Estoque mínimo:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(19, 208);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(83, 25);
            lblEstoque.TabIndex = 42;
            lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(18, 134);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(64, 25);
            lblPreco.TabIndex = 40;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.DarkGray;
            txtPreco.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(18, 162);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(285, 43);
            txtPreco.TabIndex = 39;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(20, 464);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(284, 53);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.BackColor = Color.DarkGray;
            lstProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 25;
            lstProdutos.Location = new Point(370, 88);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(324, 429);
            lstProdutos.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(18, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(131, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(436, 41);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "CADASTRE UM NOVO PRODUTO";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(18, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 43);
            txtNome.TabIndex = 1;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 534);
            Controls.Add(pnlProdutos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de produtos";
            Load += Produtos_Load;
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoque).EndInit();
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
        private Label lblPreco;
        private TextBox txtPreco;
        private CheckBox chkAtivo;
        private Label lblCategoria;
        private Label lblProdutosExistentes;
        private NumericUpDown numEstoqueMinimo;
        private NumericUpDown numEstoque;
        private ComboBox cboCategoria;
    }
}