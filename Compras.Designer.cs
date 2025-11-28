namespace Trabalho_TCD
{
    partial class Compras
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
            pnlVenda = new Panel();
            pnlTotalCompra = new Panel();
            lblValorTotal = new Label();
            lblTotalCompra = new Label();
            lblComissao = new Label();
            lblCategorias = new Label();
            cboCategorias = new ComboBox();
            btnRemoverProduto = new Button();
            lblDesconto = new Label();
            lblQuantidade = new Label();
            numDesconto = new NumericUpDown();
            numQuantidade = new NumericUpDown();
            btnAdicionarProduto = new Button();
            btnCancelarCompra = new Button();
            btnFinalizarCompra = new Button();
            lblProdutos = new Label();
            cboProdutos = new ComboBox();
            label1 = new Label();
            lblClientes = new Label();
            lsvItens = new ListView();
            cboClientes = new ComboBox();
            pnlVenda.SuspendLayout();
            pnlTotalCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // pnlVenda
            // 
            pnlVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVenda.BackColor = SystemColors.Control;
            pnlVenda.Controls.Add(pnlTotalCompra);
            pnlVenda.Controls.Add(lblComissao);
            pnlVenda.Controls.Add(lblCategorias);
            pnlVenda.Controls.Add(cboCategorias);
            pnlVenda.Controls.Add(btnRemoverProduto);
            pnlVenda.Controls.Add(lblDesconto);
            pnlVenda.Controls.Add(lblQuantidade);
            pnlVenda.Controls.Add(numDesconto);
            pnlVenda.Controls.Add(numQuantidade);
            pnlVenda.Controls.Add(btnAdicionarProduto);
            pnlVenda.Controls.Add(btnCancelarCompra);
            pnlVenda.Controls.Add(btnFinalizarCompra);
            pnlVenda.Controls.Add(lblProdutos);
            pnlVenda.Controls.Add(cboProdutos);
            pnlVenda.Controls.Add(label1);
            pnlVenda.Controls.Add(lblClientes);
            pnlVenda.Controls.Add(lsvItens);
            pnlVenda.Controls.Add(cboClientes);
            pnlVenda.Location = new Point(0, 0);
            pnlVenda.Name = "pnlVenda";
            pnlVenda.Size = new Size(1005, 657);
            pnlVenda.TabIndex = 0;
            // 
            // pnlTotalCompra
            // 
            pnlTotalCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalCompra.BackColor = SystemColors.ControlDarkDark;
            pnlTotalCompra.Controls.Add(lblValorTotal);
            pnlTotalCompra.Controls.Add(lblTotalCompra);
            pnlTotalCompra.Location = new Point(266, 515);
            pnlTotalCompra.Name = "pnlTotalCompra";
            pnlTotalCompra.Size = new Size(715, 50);
            pnlTotalCompra.TabIndex = 19;
            // 
            // lblValorTotal
            // 
            lblValorTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.ForeColor = Color.Transparent;
            lblValorTotal.Location = new Point(645, 10);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(67, 30);
            lblValorTotal.TabIndex = 2;
            lblValorTotal.Text = "00,00";
            lblValorTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCompra.ForeColor = Color.Transparent;
            lblTotalCompra.Location = new Point(0, 15);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(163, 25);
            lblTotalCompra.TabIndex = 17;
            lblTotalCompra.Text = "Total da Compra:";
            // 
            // lblComissao
            // 
            lblComissao.AutoSize = true;
            lblComissao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComissao.Location = new Point(103, 548);
            lblComissao.Name = "lblComissao";
            lblComissao.Size = new Size(121, 17);
            lblComissao.TabIndex = 18;
            lblComissao.Text = "Valor da Comissão:";
            lblComissao.Visible = false;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(21, 131);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 15;
            lblCategorias.Text = "Categorias:";
            // 
            // cboCategorias
            // 
            cboCategorias.BackColor = Color.DarkGray;
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(21, 149);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(212, 38);
            cboCategorias.TabIndex = 14;
            cboCategorias.SelectedIndexChanged += cboCategorias_SelectedIndexChanged;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.BackColor = Color.Red;
            btnRemoverProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverProduto.ForeColor = Color.Transparent;
            btnRemoverProduto.Location = new Point(21, 436);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(212, 42);
            btnRemoverProduto.TabIndex = 13;
            btnRemoverProduto.Text = "REMOVER ITEM";
            btnRemoverProduto.UseVisualStyleBackColor = false;
            btnRemoverProduto.Click += btnRemoverProduto_Click;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(21, 305);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(60, 15);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(21, 249);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 11;
            lblQuantidade.Text = "Quantidade:";
            // 
            // numDesconto
            // 
            numDesconto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDesconto.Location = new Point(21, 323);
            numDesconto.Name = "numDesconto";
            numDesconto.Size = new Size(212, 35);
            numDesconto.TabIndex = 10;
            numDesconto.ValueChanged += numDesconto_ValueChanged;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantidade.Location = new Point(21, 267);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(212, 35);
            numQuantidade.TabIndex = 9;
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.Green;
            btnAdicionarProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProduto.Location = new Point(21, 376);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(212, 42);
            btnAdicionarProduto.TabIndex = 8;
            btnAdicionarProduto.Text = "ADICIONAR ITEM";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.BackColor = Color.Red;
            btnCancelarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCompra.ForeColor = Color.Transparent;
            btnCancelarCompra.Location = new Point(522, 591);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(212, 44);
            btnCancelarCompra.TabIndex = 7;
            btnCancelarCompra.Text = "CANCELAR COMPRA";
            btnCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = Color.Green;
            btnFinalizarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarCompra.Location = new Point(769, 591);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(212, 44);
            btnFinalizarCompra.TabIndex = 6;
            btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Location = new Point(21, 190);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(58, 15);
            lblProdutos.TabIndex = 5;
            lblProdutos.Text = "Produtos:";
            // 
            // cboProdutos
            // 
            cboProdutos.BackColor = Color.DarkGray;
            cboProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProdutos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProdutos.FormattingEnabled = true;
            cboProdutos.Location = new Point(21, 208);
            cboProdutos.Name = "cboProdutos";
            cboProdutos.Size = new Size(212, 38);
            cboProdutos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 3;
            label1.Text = "VENDA";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(21, 61);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(52, 15);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes:";
            // 
            // lsvItens
            // 
            lsvItens.BackColor = Color.DarkGray;
            lsvItens.Location = new Point(266, 42);
            lsvItens.Name = "lsvItens";
            lsvItens.Size = new Size(715, 475);
            lsvItens.TabIndex = 1;
            lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(21, 79);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(212, 38);
            cboClientes.TabIndex = 0;
            cboClientes.DropDown += cboClientes_DropDown;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 657);
            Controls.Add(pnlVenda);
            MinimizeBox = false;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            WindowState = FormWindowState.Maximized;
            Load += Compras_Load;
            pnlVenda.ResumeLayout(false);
            pnlVenda.PerformLayout();
            pnlTotalCompra.ResumeLayout(false);
            pnlTotalCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVenda;
        private ListView lsvItens;
        private ComboBox cboClientes;
        private Label lblClientes;
        private Label label1;
        private ComboBox cboProdutos;
        private Label lblProdutos;
        private Button btnAdicionarProduto;
        private Button btnCancelarCompra;
        private Button btnFinalizarCompra;
        private NumericUpDown numDesconto;
        private NumericUpDown numQuantidade;
        private Label lblDesconto;
        private Label lblQuantidade;
        private Button btnRemoverProduto;
        private Label lblCategorias;
        private ComboBox cboCategorias;
        private Label lblComissao;
        private Label lblTotalCompra;
        private Panel pnlTotalCompra;
        private Label lblValorTotal;
    }
}