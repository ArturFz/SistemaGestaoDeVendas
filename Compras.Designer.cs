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
            label1 = new Label();
            lblClientes = new Label();
            lsvItens = new ListView();
            cboClientes = new ComboBox();
            pnlVenda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVenda
            // 
            pnlVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVenda.BackColor = SystemColors.Control;
            pnlVenda.Controls.Add(label1);
            pnlVenda.Controls.Add(lblClientes);
            pnlVenda.Controls.Add(lsvItens);
            pnlVenda.Controls.Add(cboClientes);
            pnlVenda.Location = new Point(0, 0);
            pnlVenda.Name = "pnlVenda";
            pnlVenda.Size = new Size(1005, 577);
            pnlVenda.TabIndex = 0;
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
            lblClientes.Location = new Point(12, 77);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(52, 15);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes:";
            // 
            // lsvItens
            // 
            lsvItens.BackColor = Color.DarkGray;
            lsvItens.Location = new Point(275, 116);
            lsvItens.Name = "lsvItens";
            lsvItens.Size = new Size(715, 396);
            lsvItens.TabIndex = 1;
            lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(12, 95);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(212, 38);
            cboClientes.TabIndex = 0;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 577);
            Controls.Add(pnlVenda);
            MinimizeBox = false;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            WindowState = FormWindowState.Maximized;
            pnlVenda.ResumeLayout(false);
            pnlVenda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVenda;
        private ListView lsvItens;
        private ComboBox cboClientes;
        private Label lblClientes;
        private Label label1;
    }
}