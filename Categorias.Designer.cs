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
            label1 = new Label();
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
            pnlCategorias.Controls.Add(label1);
            pnlCategorias.Controls.Add(btnCadastrar);
            pnlCategorias.Controls.Add(listBox1);
            pnlCategorias.Controls.Add(lblNome);
            pnlCategorias.Controls.Add(lblTitulo);
            pnlCategorias.Controls.Add(txtNome);
            pnlCategorias.Location = new Point(3, 4);
            pnlCategorias.Name = "pnlCategorias";
            pnlCategorias.Size = new Size(689, 483);
            pnlCategorias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(377, 5);
            label1.Name = "label1";
            label1.Size = new Size(277, 36);
            label1.TabIndex = 39;
            label1.Text = "Categorias Existentes:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlDarkDark;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(9, 121);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(275, 56);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkGray;
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(344, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(335, 429);
            listBox1.TabIndex = 37;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(9, 44);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 36;
            lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(9, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 36);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Cadastre uma categoria";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DarkGray;
            txtNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(9, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 43);
            txtNome.TabIndex = 1;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 490);
            Controls.Add(pnlCategorias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de categorias";
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
        private Label label1;
    }
}