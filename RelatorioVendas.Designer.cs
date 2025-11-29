namespace Trabalho_TCD
{
    partial class RelatorioVendas
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
            pnlRelatorioVendas = new Panel();
            lsvVendas = new ListView();
            btnCalcularTotal = new Button();
            txtValorTotal = new TextBox();
            txtTotalVendas = new TextBox();
            lblValorTotal = new Label();
            lblTotalVendas = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            label2 = new Label();
            lblDataInicial = new Label();
            lblTitulo = new Label();
            pnlRelatorioVendas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRelatorioVendas
            // 
            pnlRelatorioVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioVendas.Controls.Add(lsvVendas);
            pnlRelatorioVendas.Controls.Add(btnCalcularTotal);
            pnlRelatorioVendas.Controls.Add(txtValorTotal);
            pnlRelatorioVendas.Controls.Add(txtTotalVendas);
            pnlRelatorioVendas.Controls.Add(lblValorTotal);
            pnlRelatorioVendas.Controls.Add(lblTotalVendas);
            pnlRelatorioVendas.Controls.Add(dtpDataFinal);
            pnlRelatorioVendas.Controls.Add(dtpDataInicial);
            pnlRelatorioVendas.Controls.Add(label2);
            pnlRelatorioVendas.Controls.Add(lblDataInicial);
            pnlRelatorioVendas.Controls.Add(lblTitulo);
            pnlRelatorioVendas.Location = new Point(-3, -1);
            pnlRelatorioVendas.Name = "pnlRelatorioVendas";
            pnlRelatorioVendas.Size = new Size(877, 381);
            pnlRelatorioVendas.TabIndex = 0;
            // 
            // lsvVendas
            // 
            lsvVendas.BackColor = Color.DarkGray;
            lsvVendas.Location = new Point(240, 76);
            lsvVendas.Name = "lsvVendas";
            lsvVendas.Size = new Size(624, 295);
            lsvVendas.TabIndex = 10;
            lsvVendas.UseCompatibleStateImageBehavior = false;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.BackColor = SystemColors.ControlDarkDark;
            btnCalcularTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularTotal.Location = new Point(15, 319);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(200, 52);
            btnCalcularTotal.TabIndex = 9;
            btnCalcularTotal.Text = "CALCULAR VALOR TOTAL";
            btnCalcularTotal.UseVisualStyleBackColor = false;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = Color.DarkGray;
            txtValorTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTotal.Location = new Point(15, 274);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(200, 39);
            txtValorTotal.TabIndex = 8;
            // 
            // txtTotalVendas
            // 
            txtTotalVendas.BackColor = Color.DarkGray;
            txtTotalVendas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalVendas.Location = new Point(15, 208);
            txtTotalVendas.Name = "txtTotalVendas";
            txtTotalVendas.Size = new Size(200, 39);
            txtTotalVendas.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(15, 250);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(84, 21);
            lblValorTotal.TabIndex = 6;
            lblValorTotal.Text = "Valor total:";
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVendas.Location = new Point(15, 184);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(119, 21);
            lblTotalVendas.TabIndex = 5;
            lblTotalVendas.Text = "Total de vendas:";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataFinal.Location = new Point(15, 142);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(200, 39);
            dtpDataFinal.TabIndex = 4;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataInicial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataInicial.Location = new Point(15, 76);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(200, 39);
            dtpDataInicial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 118);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Data final:";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataInicial.Location = new Point(15, 52);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(89, 21);
            lblDataInicial.TabIndex = 1;
            lblDataInicial.Text = "Data inicial:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.ControlDarkDark;
            lblTitulo.Font = new Font("Noto Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(870, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Relatório de Vendas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 379);
            Controls.Add(pnlRelatorioVendas);
            Name = "RelatorioVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioVendas";
            pnlRelatorioVendas.ResumeLayout(false);
            pnlRelatorioVendas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioVendas;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label label2;
        private Label lblDataInicial;
        private Label lblTitulo;
        private TextBox txtValorTotal;
        private TextBox txtTotalVendas;
        private Label lblValorTotal;
        private Label lblTotalVendas;
        private Button btnCalcularTotal;
        private ListView lsvVendas;
    }
}