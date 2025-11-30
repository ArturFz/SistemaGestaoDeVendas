namespace Trabalho_TCD
{
    partial class RelatorioProdutos
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
            pnlRelatorioProdutos = new Panel();
            cboCategoria = new ComboBox();
            numEstoque = new NumericUpDown();
            numPreco = new NumericUpDown();
            chkAtivo = new CheckBox();
            lblCategoria = new Label();
            lblEstoque = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblProdutos = new Label();
            lstRelatorioProdutos = new ListBox();
            cboProdutos = new ComboBox();
            lblTitulo = new Label();
            pnlRelatorioProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // pnlRelatorioProdutos
            // 
            pnlRelatorioProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioProdutos.Controls.Add(cboCategoria);
            pnlRelatorioProdutos.Controls.Add(numEstoque);
            pnlRelatorioProdutos.Controls.Add(numPreco);
            pnlRelatorioProdutos.Controls.Add(chkAtivo);
            pnlRelatorioProdutos.Controls.Add(lblCategoria);
            pnlRelatorioProdutos.Controls.Add(lblEstoque);
            pnlRelatorioProdutos.Controls.Add(lblPreco);
            pnlRelatorioProdutos.Controls.Add(txtNome);
            pnlRelatorioProdutos.Controls.Add(lblNome);
            pnlRelatorioProdutos.Controls.Add(lblProdutos);
            pnlRelatorioProdutos.Controls.Add(lstRelatorioProdutos);
            pnlRelatorioProdutos.Controls.Add(cboProdutos);
            pnlRelatorioProdutos.Controls.Add(lblTitulo);
            pnlRelatorioProdutos.Location = new Point(-2, 0);
            pnlRelatorioProdutos.Name = "pnlRelatorioProdutos";
            pnlRelatorioProdutos.Size = new Size(669, 454);
            pnlRelatorioProdutos.TabIndex = 0;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(375, 319);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(278, 40);
            cboCategoria.TabIndex = 15;
            // 
            // numEstoque
            // 
            numEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEstoque.Location = new Point(375, 253);
            numEstoque.Name = "numEstoque";
            numEstoque.ReadOnly = true;
            numEstoque.Size = new Size(278, 39);
            numEstoque.TabIndex = 14;
            // 
            // numPreco
            // 
            numPreco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPreco.Location = new Point(375, 187);
            numPreco.Name = "numPreco";
            numPreco.ReadOnly = true;
            numPreco.Size = new Size(278, 39);
            numPreco.TabIndex = 13;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAtivo.Location = new Point(375, 364);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(65, 25);
            chkAtivo.TabIndex = 12;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(375, 295);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 21);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(375, 229);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(68, 21);
            lblEstoque.TabIndex = 8;
            lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(375, 163);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(52, 21);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(375, 118);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(278, 39);
            txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(375, 95);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutos.Location = new Point(14, 66);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(76, 21);
            lblProdutos.TabIndex = 3;
            lblProdutos.Text = "Produtos:";
            // 
            // lstRelatorioProdutos
            // 
            lstRelatorioProdutos.BackColor = Color.DarkGray;
            lstRelatorioProdutos.FormattingEnabled = true;
            lstRelatorioProdutos.ItemHeight = 15;
            lstRelatorioProdutos.Location = new Point(14, 134);
            lstRelatorioProdutos.Name = "lstRelatorioProdutos";
            lstRelatorioProdutos.Size = new Size(317, 289);
            lstRelatorioProdutos.TabIndex = 2;
            lstRelatorioProdutos.SelectedIndexChanged += lstRelatorioProdutos_SelectedIndexChanged;
            // 
            // cboProdutos
            // 
            cboProdutos.BackColor = Color.DarkGray;
            cboProdutos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProdutos.FormattingEnabled = true;
            cboProdutos.Location = new Point(14, 90);
            cboProdutos.Name = "cboProdutos";
            cboProdutos.Size = new Size(317, 38);
            cboProdutos.TabIndex = 1;
            cboProdutos.SelectedIndexChanged += cboProdutos_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(669, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RELATÓRIO DE PRODUTOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RelatorioProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(pnlRelatorioProdutos);
            Name = "RelatorioProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioProdutos";
            pnlRelatorioProdutos.ResumeLayout(false);
            pnlRelatorioProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioProdutos;
        private Label lblTitulo;
        private Label lblNome;
        private Label lblProdutos;
        private ListBox lstRelatorioProdutos;
        private ComboBox cboProdutos;
        private Label lblPreco;
        private TextBox txtNome;
        private Label lblCategoria;
        private Label lblEstoque;
        private CheckBox chkAtivo;
        private ComboBox cboCategoria;
        private NumericUpDown numEstoque;
        private NumericUpDown numPreco;
    }
}