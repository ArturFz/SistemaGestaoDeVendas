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
            lblAvisoCategoria = new Label();
            lblSucesso = new Label();
            lblAvisoPreco = new Label();
            lblAvisoNome = new Label();
            lblAvisoProdutoExistente = new Label();
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
            pnlProdutos.Controls.Add(lblAvisoCategoria);
            pnlProdutos.Controls.Add(lblSucesso);
            pnlProdutos.Controls.Add(lblAvisoPreco);
            pnlProdutos.Controls.Add(lblAvisoNome);
            pnlProdutos.Controls.Add(lblAvisoProdutoExistente);
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
            pnlProdutos.Location = new Point(1, 0);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(783, 652);
            pnlProdutos.TabIndex = 1;
            pnlProdutos.Paint += pnlProdutos_Paint;
            // 
            // lblAvisoCategoria
            // 
            lblAvisoCategoria.AutoSize = true;
            lblAvisoCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoCategoria.ForeColor = Color.Red;
            lblAvisoCategoria.Location = new Point(18, 484);
            lblAvisoCategoria.Name = "lblAvisoCategoria";
            lblAvisoCategoria.Size = new Size(417, 21);
            lblAvisoCategoria.TabIndex = 56;
            lblAvisoCategoria.Text = "Você deve selecionar uma categoria para o produto!!!";
            lblAvisoCategoria.Visible = false;
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucesso.ForeColor = Color.Green;
            lblSucesso.Location = new Point(18, 484);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(274, 21);
            lblSucesso.TabIndex = 55;
            lblSucesso.Text = "Produto cadastrado com sucesso!!!";
            lblSucesso.Visible = false;
            // 
            // lblAvisoPreco
            // 
            lblAvisoPreco.AutoSize = true;
            lblAvisoPreco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoPreco.ForeColor = Color.Red;
            lblAvisoPreco.Location = new Point(18, 484);
            lblAvisoPreco.Name = "lblAvisoPreco";
            lblAvisoPreco.Size = new Size(352, 21);
            lblAvisoPreco.TabIndex = 54;
            lblAvisoPreco.Text = "Você deve definir um preço para o produto!!!";
            lblAvisoPreco.Visible = false;
            // 
            // lblAvisoNome
            // 
            lblAvisoNome.AutoSize = true;
            lblAvisoNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoNome.ForeColor = Color.Red;
            lblAvisoNome.Location = new Point(18, 484);
            lblAvisoNome.Name = "lblAvisoNome";
            lblAvisoNome.Size = new Size(353, 21);
            lblAvisoNome.TabIndex = 53;
            lblAvisoNome.Text = "Você deve digitar um nome para o produto!!!";
            lblAvisoNome.Visible = false;
            // 
            // lblAvisoProdutoExistente
            // 
            lblAvisoProdutoExistente.AutoSize = true;
            lblAvisoProdutoExistente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoProdutoExistente.ForeColor = Color.Red;
            lblAvisoProdutoExistente.Location = new Point(27, 484);
            lblAvisoProdutoExistente.Name = "lblAvisoProdutoExistente";
            lblAvisoProdutoExistente.Size = new Size(190, 21);
            lblAvisoProdutoExistente.TabIndex = 52;
            lblAvisoProdutoExistente.Text = "Esse produto já existe!!!";
            lblAvisoProdutoExistente.Visible = false;
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.DarkGray;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(20, 406);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(284, 40);
            cboCategoria.TabIndex = 51;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged_1;
            // 
            // numEstoque
            // 
            numEstoque.BackColor = Color.DarkGray;
            numEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoque.Location = new Point(20, 269);
            numEstoque.Name = "numEstoque";
            numEstoque.Size = new Size(284, 39);
            numEstoque.TabIndex = 50;
            // 
            // numEstoqueMinimo
            // 
            numEstoqueMinimo.BackColor = Color.DarkGray;
            numEstoqueMinimo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoqueMinimo.Location = new Point(21, 339);
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
            lblProdutosExistentes.Location = new Point(490, 74);
            lblProdutosExistentes.Name = "lblProdutosExistentes";
            lblProdutosExistentes.Size = new Size(231, 29);
            lblProdutosExistentes.TabIndex = 48;
            lblProdutosExistentes.Text = "PRODUTOS EXISTENTES";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(20, 378);
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
            chkAtivo.Location = new Point(20, 211);
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
            lblEstoqueMinimo.Location = new Point(20, 311);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(152, 25);
            lblEstoqueMinimo.TabIndex = 44;
            lblEstoqueMinimo.Text = "Estoque mínimo:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(20, 241);
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
            btnCadastrar.Location = new Point(17, 582);
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
            lstProdutos.Location = new Point(444, 106);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(324, 529);
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
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(783, 48);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "CADASTRE UM NOVO PRODUTO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 653);
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
        private Label lblAvisoProdutoExistente;
        private Label lblAvisoNome;
        private Label lblAvisoPreco;
        private Label lblSucesso;
        private Label lblAvisoCategoria;
    }
}