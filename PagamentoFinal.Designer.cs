namespace Trabalho_TCD
{
    partial class PagamentoFinal
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
            pnlPagamentoFinal = new Panel();
            lstParcelas = new ListBox();
            lstCompras = new ListBox();
            btnFinalizarPagamento = new Button();
            lblEstado = new Label();
            lblValorParcelas = new Label();
            lblParcelas = new Label();
            lblValorTotal = new Label();
            txtEstado = new TextBox();
            txtValorParcelas = new TextBox();
            txtValorTotal = new TextBox();
            lblCompras = new Label();
            lblClientes = new Label();
            cboClientes = new ComboBox();
            lblTitulo = new Label();
            pnlPagamentoFinal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPagamentoFinal
            // 
            pnlPagamentoFinal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPagamentoFinal.Controls.Add(lstParcelas);
            pnlPagamentoFinal.Controls.Add(lstCompras);
            pnlPagamentoFinal.Controls.Add(btnFinalizarPagamento);
            pnlPagamentoFinal.Controls.Add(lblEstado);
            pnlPagamentoFinal.Controls.Add(lblValorParcelas);
            pnlPagamentoFinal.Controls.Add(lblParcelas);
            pnlPagamentoFinal.Controls.Add(lblValorTotal);
            pnlPagamentoFinal.Controls.Add(txtEstado);
            pnlPagamentoFinal.Controls.Add(txtValorParcelas);
            pnlPagamentoFinal.Controls.Add(txtValorTotal);
            pnlPagamentoFinal.Controls.Add(lblCompras);
            pnlPagamentoFinal.Controls.Add(lblClientes);
            pnlPagamentoFinal.Controls.Add(cboClientes);
            pnlPagamentoFinal.Controls.Add(lblTitulo);
            pnlPagamentoFinal.Location = new Point(-4, 0);
            pnlPagamentoFinal.Name = "pnlPagamentoFinal";
            pnlPagamentoFinal.Size = new Size(805, 506);
            pnlPagamentoFinal.TabIndex = 0;
            // 
            // lstParcelas
            // 
            lstParcelas.FormattingEnabled = true;
            lstParcelas.ItemHeight = 15;
            lstParcelas.Location = new Point(16, 330);
            lstParcelas.Name = "lstParcelas";
            lstParcelas.Size = new Size(176, 154);
            lstParcelas.TabIndex = 15;
            // 
            // lstCompras
            // 
            lstCompras.FormattingEnabled = true;
            lstCompras.ItemHeight = 15;
            lstCompras.Location = new Point(16, 145);
            lstCompras.Name = "lstCompras";
            lstCompras.Size = new Size(176, 154);
            lstCompras.TabIndex = 14;
            // 
            // btnFinalizarPagamento
            // 
            btnFinalizarPagamento.BackColor = SystemColors.ControlDarkDark;
            btnFinalizarPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarPagamento.Location = new Point(571, 425);
            btnFinalizarPagamento.Name = "btnFinalizarPagamento";
            btnFinalizarPagamento.Size = new Size(221, 59);
            btnFinalizarPagamento.TabIndex = 13;
            btnFinalizarPagamento.Text = "PAGAR PARCELA";
            btnFinalizarPagamento.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(616, 210);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:";
            // 
            // lblValorParcelas
            // 
            lblValorParcelas.AutoSize = true;
            lblValorParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorParcelas.Location = new Point(616, 54);
            lblValorParcelas.Name = "lblValorParcelas";
            lblValorParcelas.Size = new Size(137, 21);
            lblValorParcelas.TabIndex = 11;
            lblValorParcelas.Text = "Valor das Parcelas:";
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParcelas.Location = new Point(16, 301);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(69, 21);
            lblParcelas.TabIndex = 10;
            lblParcelas.Text = "Parcelas:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(616, 129);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(84, 21);
            lblValorTotal.TabIndex = 9;
            lblValorTotal.Text = "Valor total:";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(616, 234);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(176, 35);
            txtEstado.TabIndex = 8;
            // 
            // txtValorParcelas
            // 
            txtValorParcelas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorParcelas.Location = new Point(616, 78);
            txtValorParcelas.Name = "txtValorParcelas";
            txtValorParcelas.Size = new Size(176, 35);
            txtValorParcelas.TabIndex = 7;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTotal.Location = new Point(616, 154);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(176, 35);
            txtValorTotal.TabIndex = 5;
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompras.Location = new Point(16, 116);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(76, 21);
            lblCompras.TabIndex = 4;
            lblCompras.Text = "Compras:";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientes.Location = new Point(16, 51);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(68, 21);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes:";
            // 
            // cboClientes
            // 
            cboClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(16, 75);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(176, 38);
            cboClientes.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(805, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "FAÇA O PAGAMENTO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PagamentoFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(pnlPagamentoFinal);
            Name = "PagamentoFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagamentoFinal";
            pnlPagamentoFinal.ResumeLayout(false);
            pnlPagamentoFinal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPagamentoFinal;
        private TextBox txtEstado;
        private TextBox txtValorParcelas;
        private TextBox textBox2;
        private TextBox txtValorTotal;
        private Label lblCompras;
        private Label lblClientes;
        private ComboBox cboClientes;
        private Label lblTitulo;
        private Label lblParcelas;
        private Label lblValorTotal;
        private Button btnFinalizarPagamento;
        private Label lblEstado;
        private Label lblValorParcelas;
        private ListBox lstCompras;
        private ListBox lstParcelas;
    }
}