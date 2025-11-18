namespace Trabalho_TCD
{
    partial class Categorias
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
            pnlCategorias = new Panel();
            btnCadastrar = new Button();
            listBox1 = new ListBox();
            lblNome = new Label();
            lblTitulo = new Label();
            txtNome = new TextBox();
            pnlCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCategorias
            // 
            pnlCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCategorias.Controls.Add(btnCadastrar);
            pnlCategorias.Controls.Add(listBox1);
            pnlCategorias.Controls.Add(lblNome);
            pnlCategorias.Controls.Add(lblTitulo);
            pnlCategorias.Controls.Add(txtNome);
            pnlCategorias.Location = new Point(3, 4);
            pnlCategorias.Name = "pnlCategorias";
            pnlCategorias.Size = new Size(792, 575);
            pnlCategorias.TabIndex = 0;
            pnlCategorias.Paint += panel1_Paint;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(604, 505);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(178, 55);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 559);
            listBox1.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(351, 57);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(340, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(442, 44);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Cadastre uma nova categoria";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(351, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 33);
            txtNome.TabIndex = 1;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 582);
            Controls.Add(pnlCategorias);
            Name = "Categorias";
            Text = "Categorias";
            pnlCategorias.ResumeLayout(false);
            pnlCategorias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategorias;
        private TextBox txtNome;
        private Label lblTitulo;
        private Label lblNome;
        private ListBox listBox1;
        private Button btnCadastrar;
    }
}