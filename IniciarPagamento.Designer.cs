namespace Trabalho_TCD
{
    partial class IniciarPagamento
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
            lblAviso = new Label();
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
            pnlPrincipal.Controls.Add(lblAviso);
            pnlPrincipal.Controls.Add(lblTitulo);
            pnlPrincipal.Controls.Add(lblSelecionarCliente);
            pnlPrincipal.Controls.Add(cboClientes);
            pnlPrincipal.Controls.Add(btnIniciarPagamento);
            pnlPrincipal.Location = new Point(1, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(483, 307);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(35, 275);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(410, 21);
            lblAviso.TabIndex = 4;
            lblAviso.Text = "Selecione um cliente antes de iniciar o pagamento!!!";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
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
            lblSelecionarCliente.ForeColor = Color.DimGray;
            lblSelecionarCliente.Location = new Point(81, 77);
            lblSelecionarCliente.Name = "lblSelecionarCliente";
            lblSelecionarCliente.Size = new Size(155, 20);
            lblSelecionarCliente.TabIndex = 2;
            lblSelecionarCliente.Text = "Selecione um cliente:";
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(81, 100);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(327, 45);
            cboClientes.TabIndex = 1;
            cboClientes.DropDown += cboClientes_DropDown;
            // 
            // btnIniciarPagamento
            // 
            btnIniciarPagamento.BackColor = SystemColors.ControlDarkDark;
            btnIniciarPagamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarPagamento.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarPagamento.Location = new Point(81, 186);
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
            ClientSize = new Size(485, 313);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
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
        private Label lblAviso;
    }
}