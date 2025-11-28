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
            txtValorParcela = new TextBox();
            lblValorParcela = new Label();
            lblQuantidadeParcelas = new Label();
            numQuantidadeParcelas = new NumericUpDown();
            pnlAutorizacaoGerente = new Panel();
            lblTitulo = new Label();
            btnCancelar = new Button();
            btnAutorizar = new Button();
            lblSenha = new Label();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            txtSenha = new TextBox();
            pnlComissao = new Panel();
            lblComissaoTotal = new Label();
            lblValorComissao = new Label();
            pnlTotalCompra = new Panel();
            lblValorTotal = new Label();
            lblTotalCompra = new Label();
            lblCategorias = new Label();
            cboCategorias = new ComboBox();
            btnRemoverProduto = new Button();
            lblDesconto = new Label();
            lblQuantidade = new Label();
            numDesconto = new NumericUpDown();
            numQuantidade = new NumericUpDown();
            btnAdicionarProduto = new Button();
            btnCancelarVenda = new Button();
            btnFinalizarVenda = new Button();
            lblProdutos = new Label();
            cboProdutos = new ComboBox();
            label1 = new Label();
            lblClientes = new Label();
            lsvItens = new ListView();
            cboClientes = new ComboBox();
            pnlVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeParcelas).BeginInit();
            pnlAutorizacaoGerente.SuspendLayout();
            pnlComissao.SuspendLayout();
            pnlTotalCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // pnlVenda
            // 
            pnlVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVenda.BackColor = Color.LightGray;
            pnlVenda.Controls.Add(txtValorParcela);
            pnlVenda.Controls.Add(lblValorParcela);
            pnlVenda.Controls.Add(lblQuantidadeParcelas);
            pnlVenda.Controls.Add(numQuantidadeParcelas);
            pnlVenda.Controls.Add(pnlAutorizacaoGerente);
            pnlVenda.Controls.Add(pnlComissao);
            pnlVenda.Controls.Add(pnlTotalCompra);
            pnlVenda.Controls.Add(lblCategorias);
            pnlVenda.Controls.Add(cboCategorias);
            pnlVenda.Controls.Add(btnRemoverProduto);
            pnlVenda.Controls.Add(lblDesconto);
            pnlVenda.Controls.Add(lblQuantidade);
            pnlVenda.Controls.Add(numDesconto);
            pnlVenda.Controls.Add(numQuantidade);
            pnlVenda.Controls.Add(btnAdicionarProduto);
            pnlVenda.Controls.Add(btnCancelarVenda);
            pnlVenda.Controls.Add(btnFinalizarVenda);
            pnlVenda.Controls.Add(lblProdutos);
            pnlVenda.Controls.Add(cboProdutos);
            pnlVenda.Controls.Add(label1);
            pnlVenda.Controls.Add(lblClientes);
            pnlVenda.Controls.Add(lsvItens);
            pnlVenda.Controls.Add(cboClientes);
            pnlVenda.Location = new Point(0, 0);
            pnlVenda.Name = "pnlVenda";
            pnlVenda.Size = new Size(1098, 884);
            pnlVenda.TabIndex = 0;
            // 
            // txtValorParcela
            // 
            txtValorParcela.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorParcela.Location = new Point(21, 405);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.Size = new Size(212, 35);
            txtValorParcela.TabIndex = 25;
            // 
            // lblValorParcela
            // 
            lblValorParcela.AutoSize = true;
            lblValorParcela.Location = new Point(21, 387);
            lblValorParcela.Name = "lblValorParcela";
            lblValorParcela.Size = new Size(93, 15);
            lblValorParcela.TabIndex = 24;
            lblValorParcela.Text = "Valor da parcela:";
            // 
            // lblQuantidadeParcelas
            // 
            lblQuantidadeParcelas.AutoSize = true;
            lblQuantidadeParcelas.Location = new Point(21, 331);
            lblQuantidadeParcelas.Name = "lblQuantidadeParcelas";
            lblQuantidadeParcelas.Size = new Size(134, 15);
            lblQuantidadeParcelas.TabIndex = 23;
            lblQuantidadeParcelas.Text = "Quantidade de parcelas:";
            // 
            // numQuantidadeParcelas
            // 
            numQuantidadeParcelas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantidadeParcelas.Location = new Point(21, 349);
            numQuantidadeParcelas.Name = "numQuantidadeParcelas";
            numQuantidadeParcelas.Size = new Size(212, 35);
            numQuantidadeParcelas.TabIndex = 22;
            numQuantidadeParcelas.ValueChanged += numQuantidadeParcelas_ValueChanged;
            // 
            // pnlAutorizacaoGerente
            // 
            pnlAutorizacaoGerente.Controls.Add(lblTitulo);
            pnlAutorizacaoGerente.Controls.Add(btnCancelar);
            pnlAutorizacaoGerente.Controls.Add(btnAutorizar);
            pnlAutorizacaoGerente.Controls.Add(lblSenha);
            pnlAutorizacaoGerente.Controls.Add(lblNomeUsuario);
            pnlAutorizacaoGerente.Controls.Add(txtNomeUsuario);
            pnlAutorizacaoGerente.Controls.Add(txtSenha);
            pnlAutorizacaoGerente.Location = new Point(21, 625);
            pnlAutorizacaoGerente.Name = "pnlAutorizacaoGerente";
            pnlAutorizacaoGerente.Size = new Size(310, 247);
            pnlAutorizacaoGerente.TabIndex = 21;
            pnlAutorizacaoGerente.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(41, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 24);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "AUTORIZAÇÃO DO GERENTE";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Location = new Point(13, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 48);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Anchor = AnchorStyles.None;
            btnAutorizar.BackColor = Color.Green;
            btnAutorizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorizar.Location = new Point(159, 191);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(137, 48);
            btnAutorizar.TabIndex = 26;
            btnAutorizar.Text = "AUTORIZAR";
            btnAutorizar.UseVisualStyleBackColor = false;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.None;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(17, 118);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 24);
            lblSenha.TabIndex = 25;
            lblSenha.Text = "Senha:";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Anchor = AnchorStyles.None;
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(13, 45);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(147, 24);
            lblNomeUsuario.TabIndex = 24;
            lblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Anchor = AnchorStyles.None;
            txtNomeUsuario.BackColor = Color.DarkGray;
            txtNomeUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(13, 72);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(283, 43);
            txtNomeUsuario.TabIndex = 22;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BackColor = Color.DarkGray;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(17, 142);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(279, 43);
            txtSenha.TabIndex = 23;
            // 
            // pnlComissao
            // 
            pnlComissao.BackColor = SystemColors.ActiveCaptionText;
            pnlComissao.Controls.Add(lblComissaoTotal);
            pnlComissao.Controls.Add(lblValorComissao);
            pnlComissao.Location = new Point(371, 593);
            pnlComissao.Name = "pnlComissao";
            pnlComissao.Size = new Size(715, 57);
            pnlComissao.TabIndex = 20;
            // 
            // lblComissaoTotal
            // 
            lblComissaoTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComissaoTotal.ForeColor = Color.Transparent;
            lblComissaoTotal.Location = new Point(503, 14);
            lblComissaoTotal.Name = "lblComissaoTotal";
            lblComissaoTotal.Size = new Size(209, 27);
            lblComissaoTotal.TabIndex = 19;
            lblComissaoTotal.Text = "R$ 00,00";
            lblComissaoTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // lblValorComissao
            // 
            lblValorComissao.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorComissao.ForeColor = Color.Transparent;
            lblValorComissao.Location = new Point(3, 14);
            lblValorComissao.Name = "lblValorComissao";
            lblValorComissao.Size = new Size(202, 27);
            lblValorComissao.TabIndex = 18;
            lblValorComissao.Text = "Valor da Comissão:";
            // 
            // pnlTotalCompra
            // 
            pnlTotalCompra.BackColor = SystemColors.ControlDarkDark;
            pnlTotalCompra.Controls.Add(lblValorTotal);
            pnlTotalCompra.Controls.Add(lblTotalCompra);
            pnlTotalCompra.Location = new Point(371, 539);
            pnlTotalCompra.Name = "pnlTotalCompra";
            pnlTotalCompra.Size = new Size(715, 57);
            pnlTotalCompra.TabIndex = 19;
            // 
            // lblValorTotal
            // 
            lblValorTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.ForeColor = Color.Transparent;
            lblValorTotal.Location = new Point(503, 11);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(209, 27);
            lblValorTotal.TabIndex = 2;
            lblValorTotal.Text = "R$ 00,00";
            lblValorTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCompra.ForeColor = Color.Transparent;
            lblTotalCompra.Location = new Point(0, 14);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(194, 27);
            lblTotalCompra.TabIndex = 17;
            lblTotalCompra.Text = "Total da Compra:";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(21, 101);
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
            cboCategorias.Location = new Point(21, 119);
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
            btnRemoverProduto.Location = new Point(21, 550);
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
            lblDesconto.Location = new Point(21, 275);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(60, 15);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(21, 219);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 11;
            lblQuantidade.Text = "Quantidade:";
            // 
            // numDesconto
            // 
            numDesconto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDesconto.Location = new Point(21, 293);
            numDesconto.Name = "numDesconto";
            numDesconto.Size = new Size(212, 35);
            numDesconto.TabIndex = 10;
            numDesconto.ValueChanged += numDesconto_ValueChanged;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantidade.Location = new Point(21, 237);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(212, 35);
            numQuantidade.TabIndex = 9;
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.Green;
            btnAdicionarProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProduto.Location = new Point(21, 500);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(212, 42);
            btnAdicionarProduto.TabIndex = 8;
            btnAdicionarProduto.Text = "ADICIONAR ITEM";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.BackColor = Color.Red;
            btnCancelarVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarVenda.ForeColor = Color.Transparent;
            btnCancelarVenda.Location = new Point(521, 686);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(212, 44);
            btnCancelarVenda.TabIndex = 7;
            btnCancelarVenda.Text = "CANCELAR VENDA";
            btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.Green;
            btnFinalizarVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenda.Location = new Point(769, 686);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(212, 44);
            btnFinalizarVenda.TabIndex = 6;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Location = new Point(21, 160);
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
            cboProdutos.Location = new Point(21, 178);
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
            lblClientes.Location = new Point(21, 42);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(52, 15);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes:";
            // 
            // lsvItens
            // 
            lsvItens.BackColor = Color.DarkGray;
            lsvItens.Location = new Point(371, 42);
            lsvItens.Name = "lsvItens";
            lsvItens.Size = new Size(715, 500);
            lsvItens.TabIndex = 1;
            lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(21, 60);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(212, 38);
            cboClientes.TabIndex = 0;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 884);
            Controls.Add(pnlVenda);
            MinimizeBox = false;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            WindowState = FormWindowState.Maximized;
            Load += Compras_Load;
            pnlVenda.ResumeLayout(false);
            pnlVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeParcelas).EndInit();
            pnlAutorizacaoGerente.ResumeLayout(false);
            pnlAutorizacaoGerente.PerformLayout();
            pnlComissao.ResumeLayout(false);
            pnlTotalCompra.ResumeLayout(false);
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
        private Button btnCancelarVenda;
        private Button btnFinalizarVenda;
        private NumericUpDown numDesconto;
        private NumericUpDown numQuantidade;
        private Label lblDesconto;
        private Label lblQuantidade;
        private Button btnRemoverProduto;
        private Label lblCategorias;
        private ComboBox cboCategorias;
        private Label lblTotalCompra;
        private Panel pnlTotalCompra;
        private Label lblValorTotal;
        private Panel pnlComissao;
        private Label lblValorComissao;
        private Label lblComissaoTotal;
        private Panel pnlAutorizacaoGerente;
        private Label lblSenha;
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private TextBox txtSenha;
        private Button btnCancelar;
        private Button btnAutorizar;
        private Label lblTitulo;
        private Label lblQuantidadeParcelas;
        private NumericUpDown numQuantidadeParcelas;
        private Label lblValorParcela;
        private TextBox txtValorParcela;
    }
}