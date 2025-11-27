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
            cboProdutos = new ComboBox();
            label1 = new Label();
            lblClientes = new Label();
            lsvItens = new ListView();
            cboClientes = new ComboBox();
            lblProdutos = new Label();
            btnFinalizarCompra = new Button();
            btnCancelarCompra = new Button();
            btnAdicionarProduto = new Button();
            numQuantidade = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            lblQuantidade = new Label();
            lblDesconto = new Label();
            pnlVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pnlVenda
            // 
            pnlVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVenda.BackColor = SystemColors.Control;
            pnlVenda.Controls.Add(lblDesconto);
            pnlVenda.Controls.Add(lblQuantidade);
            pnlVenda.Controls.Add(numericUpDown1);
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
            // cboProdutos
            // 
            cboProdutos.BackColor = Color.DarkGray;
            cboProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProdutos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProdutos.FormattingEnabled = true;
            cboProdutos.Location = new Point(12, 137);
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
            lblClientes.Location = new Point(12, 43);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(52, 15);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes:";
            // 
            // lsvItens
            // 
            lsvItens.BackColor = Color.DarkGray;
            lsvItens.Location = new Point(278, 61);
            lsvItens.Name = "lsvItens";
            lsvItens.Size = new Size(715, 522);
            lsvItens.TabIndex = 1;
            lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(12, 61);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(212, 38);
            cboClientes.TabIndex = 0;
            cboClientes.DropDown += cboClientes_DropDown;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Location = new Point(12, 119);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(58, 15);
            lblProdutos.TabIndex = 5;
            lblProdutos.Text = "Produtos:";
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Location = new Point(856, 601);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(137, 44);
            btnFinalizarCompra.TabIndex = 6;
            btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Location = new Point(671, 601);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(154, 44);
            btnCancelarCompra.TabIndex = 7;
            btnCancelarCompra.Text = "CANCELAR COMPRA";
            btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(12, 356);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(212, 42);
            btnAdicionarProduto.TabIndex = 8;
            btnAdicionarProduto.Text = "ADICIONAR PRODUTO";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantidade.Location = new Point(12, 217);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(212, 35);
            numQuantidade.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(12, 288);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(212, 35);
            numericUpDown1.TabIndex = 10;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 199);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 11;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(12, 270);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(60, 15);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto:";
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
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private NumericUpDown numQuantidade;
        private Label lblDesconto;
        private Label lblQuantidade;
    }
}