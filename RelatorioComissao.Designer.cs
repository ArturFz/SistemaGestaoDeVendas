namespace Trabalho_TCD
{
    partial class RelatorioComissao
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
            pnlRelatorioComissao = new Panel();
            btnCalcularComissao = new Button();
            lblComissaoTotal = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            lblMatricula = new Label();
            txtComissaoTotal = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            lblVendedor = new Label();
            cboVendedor = new ComboBox();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            lblTitulo = new Label();
            pnlRelatorioComissao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRelatorioComissao
            // 
            pnlRelatorioComissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioComissao.Controls.Add(btnCalcularComissao);
            pnlRelatorioComissao.Controls.Add(lblComissaoTotal);
            pnlRelatorioComissao.Controls.Add(lblEmail);
            pnlRelatorioComissao.Controls.Add(lblNome);
            pnlRelatorioComissao.Controls.Add(lblMatricula);
            pnlRelatorioComissao.Controls.Add(txtComissaoTotal);
            pnlRelatorioComissao.Controls.Add(txtEmail);
            pnlRelatorioComissao.Controls.Add(txtNome);
            pnlRelatorioComissao.Controls.Add(txtMatricula);
            pnlRelatorioComissao.Controls.Add(lblVendedor);
            pnlRelatorioComissao.Controls.Add(cboVendedor);
            pnlRelatorioComissao.Controls.Add(dtpDataFinal);
            pnlRelatorioComissao.Controls.Add(dtpDataInicial);
            pnlRelatorioComissao.Controls.Add(lblDataFinal);
            pnlRelatorioComissao.Controls.Add(lblDataInicial);
            pnlRelatorioComissao.Controls.Add(lblTitulo);
            pnlRelatorioComissao.Location = new Point(-2, -1);
            pnlRelatorioComissao.Name = "pnlRelatorioComissao";
            pnlRelatorioComissao.Size = new Size(608, 352);
            pnlRelatorioComissao.TabIndex = 0;
            // 
            // btnCalcularComissao
            // 
            btnCalcularComissao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularComissao.ForeColor = Color.Black;
            btnCalcularComissao.Location = new Point(14, 294);
            btnCalcularComissao.Name = "btnCalcularComissao";
            btnCalcularComissao.Size = new Size(200, 42);
            btnCalcularComissao.TabIndex = 15;
            btnCalcularComissao.Text = "CALCULAR COMISSÃO";
            btnCalcularComissao.UseVisualStyleBackColor = true;
            btnCalcularComissao.Click += btnCalcularComissao_Click;
            // 
            // lblComissaoTotal
            // 
            lblComissaoTotal.AutoSize = true;
            lblComissaoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComissaoTotal.Location = new Point(383, 269);
            lblComissaoTotal.Name = "lblComissaoTotal";
            lblComissaoTotal.Size = new Size(140, 25);
            lblComissaoTotal.TabIndex = 14;
            lblComissaoTotal.Text = "Comissão total:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(383, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 25);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(383, 59);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(383, 129);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(96, 25);
            lblMatricula.TabIndex = 11;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtComissaoTotal
            // 
            txtComissaoTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComissaoTotal.Location = new Point(383, 297);
            txtComissaoTotal.Name = "txtComissaoTotal";
            txtComissaoTotal.Size = new Size(200, 39);
            txtComissaoTotal.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(383, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(383, 87);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 39);
            txtNome.TabIndex = 8;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(383, 155);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(200, 39);
            txtMatricula.TabIndex = 7;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14.25F);
            lblVendedor.Location = new Point(14, 59);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(98, 25);
            lblVendedor.TabIndex = 6;
            lblVendedor.Text = "Vendedor:";
            // 
            // cboVendedor
            // 
            cboVendedor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(14, 86);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(200, 40);
            cboVendedor.TabIndex = 5;
            cboVendedor.SelectedIndexChanged += cboVendedor_SelectedIndexChanged;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(14, 227);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(200, 39);
            dtpDataFinal.TabIndex = 4;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(14, 155);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(200, 39);
            dtpDataInicial.TabIndex = 3;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Font = new Font("Segoe UI", 14.25F);
            lblDataFinal.Location = new Point(14, 199);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(100, 25);
            lblDataFinal.TabIndex = 2;
            lblDataFinal.Text = "Data Final:";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Font = new Font("Segoe UI", 14.25F);
            lblDataInicial.Location = new Point(14, 129);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(110, 25);
            lblDataInicial.TabIndex = 1;
            lblDataInicial.Text = "Data Inicial:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(608, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RELATÓRIO DE COMISSÃO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RelatorioComissao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 349);
            Controls.Add(pnlRelatorioComissao);
            Name = "RelatorioComissao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioComissao";
            pnlRelatorioComissao.ResumeLayout(false);
            pnlRelatorioComissao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioComissao;
        private Label lblTitulo;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private Label lblVendedor;
        private ComboBox cboVendedor;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label lblComissaoTotal;
        private Label lblEmail;
        private Label lblNome;
        private Label lblMatricula;
        private TextBox txtComissaoTotal;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private Button btnCalcularComissao;
    }
}