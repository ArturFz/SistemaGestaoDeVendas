namespace Trabalho_TCD
{
    partial class Venda
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
            SuspendLayout();
            // 
            // pnlVenda
            // 
            pnlVenda.Location = new Point(3, 3);
            pnlVenda.Name = "pnlVenda";
            pnlVenda.Size = new Size(795, 446);
            pnlVenda.TabIndex = 0;
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlVenda);
            Name = "Venda";
            Text = "Venda";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVenda;
    }
}