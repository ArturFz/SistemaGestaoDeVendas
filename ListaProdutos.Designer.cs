namespace Trabalho_TCD
{
    partial class ListaProdutos
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
            lsvListaProdutos = new ListView();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lsvListaProdutos
            // 
            lsvListaProdutos.Location = new Point(104, 38);
            lsvListaProdutos.Name = "lsvListaProdutos";
            lsvListaProdutos.Size = new Size(775, 326);
            lsvListaProdutos.TabIndex = 0;
            lsvListaProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lsvListaProdutos);
            panel1.Location = new Point(2, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 624);
            panel1.TabIndex = 1;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 634);
            Controls.Add(panel1);
            Name = "ListaProdutos";
            Text = "Lista de Produtos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvListaProdutos;
        private Panel panel1;
    }
}