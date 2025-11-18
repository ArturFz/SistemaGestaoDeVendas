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
            lblCategorias = new Label();
            lstCategorias = new ListBox();
            chkAtivo = new CheckBox();
            lblEstoqueMinimo = new Label();
            txtEstoqueMinimo = new TextBox();
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
            SuspendLayout();
            // 
            // pnlProdutos
            // 
            pnlProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProdutos.Controls.Add(lblCategorias);
            pnlProdutos.Controls.Add(lstCategorias);
            pnlProdutos.Controls.Add(chkAtivo);
            pnlProdutos.Controls.Add(lblEstoqueMinimo);
            pnlProdutos.Controls.Add(txtEstoqueMinimo);
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
            pnlProdutos.Size = new Size(745, 612);
            pnlProdutos.TabIndex = 1;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorias.Location = new Point(350, 320);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(87, 21);
            lblCategorias.TabIndex = 47;
            lblCategorias.Text = "Categorias:";
            // 
            // lstCategorias
            // 
            lstCategorias.BackColor = SystemColors.ScrollBar;
            lstCategorias.FormattingEnabled = true;
            lstCategorias.ItemHeight = 15;
            lstCategorias.Location = new Point(354, 344);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(198, 259);
            lstCategorias.TabIndex = 46;
            lstCategorias.Tag = "";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAtivo.Location = new Point(354, 293);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(65, 25);
            chkAtivo.TabIndex = 45;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.AutoSize = true;
            lblEstoqueMinimo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoqueMinimo.Location = new Point(350, 226);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(126, 21);
            lblEstoqueMinimo.TabIndex = 44;
            lblEstoqueMinimo.Text = "Estoque mínimo:";
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstoqueMinimo.Location = new Point(354, 250);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(198, 33);
            txtEstoqueMinimo.TabIndex = 43;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(350, 166);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(68, 21);
            lblEstoque.TabIndex = 42;
            lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            txtEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstoque.Location = new Point(354, 190);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(198, 33);
            txtEstoque.TabIndex = 41;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(350, 106);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(52, 21);
            lblPreco.TabIndex = 40;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(354, 130);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(198, 33);
            txtPreco.TabIndex = 39;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(568, 560);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 43);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(8, 14);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(319, 589);
            lstProdutos.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(350, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(350, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(377, 41);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Cadastre um novo produto";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(354, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 33);
            txtNome.TabIndex = 1;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 616);
            Controls.Add(pnlProdutos);
            Name = "Produtos";
            Text = "Produtos";
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
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
        private TextBox txtEstoqueMinimo;
        private Label lblEstoque;
        private TextBox txtEstoque;
        private Label lblPreco;
        private TextBox txtPreco;
        private CheckBox chkAtivo;
        private ListBox lstCategorias;
        private Label lblCategorias;
    }
}