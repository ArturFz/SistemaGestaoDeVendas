namespace Trabalho_TCD
{
    partial class Pagamentos
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
            pnlPrincipal = new Panel();
            lblTitulo = new Label();
            lblSelecionarCliente = new Label();
            cboClientes = new ComboBox();
            btnIniciarPagamento = new Button();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblTitulo);
            pnlPrincipal.Controls.Add(lblSelecionarCliente);
            pnlPrincipal.Controls.Add(cboClientes);
            pnlPrincipal.Controls.Add(btnIniciarPagamento);
            pnlPrincipal.Location = new Point(1, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(483, 319);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(96, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "INICIAR PAGAMENTO";
            // 
            // lblSelecionarCliente
            // 
            lblSelecionarCliente.AutoSize = true;
            lblSelecionarCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelecionarCliente.ForeColor = Color.DarkGray;
            lblSelecionarCliente.Location = new Point(77, 105);
            lblSelecionarCliente.Name = "lblSelecionarCliente";
            lblSelecionarCliente.Size = new Size(155, 20);
            lblSelecionarCliente.TabIndex = 2;
            lblSelecionarCliente.Text = "Selecione um cliente:";
            // 
            // cboClientes
            // 
            cboClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(77, 128);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(327, 45);
            cboClientes.TabIndex = 1;
            // 
            // btnIniciarPagamento
            // 
            btnIniciarPagamento.BackColor = SystemColors.ControlDarkDark;
            btnIniciarPagamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarPagamento.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarPagamento.Location = new Point(77, 226);
            btnIniciarPagamento.Name = "btnIniciarPagamento";
            btnIniciarPagamento.Size = new Size(327, 58);
            btnIniciarPagamento.TabIndex = 0;
            btnIniciarPagamento.Text = "INICIAR PROCESSO DE PAGAMENTO";
            btnIniciarPagamento.UseVisualStyleBackColor = false;
            btnIniciarPagamento.Click += btnIniciarPagamento_Click;
            // 
            // Pagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 325);
            Controls.Add(pnlPrincipal);
            MinimizeBox = false;
            Name = "Pagamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Pagamento";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private ComboBox cboClientes;
        private Button btnIniciarPagamento;
        private Label lblSelecionarCliente;
        private Label lblTitulo;
    }
}