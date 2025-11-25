namespace Trabalho1_ProgVis
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            lblTitulo = new Label();
            pnlSobre = new Panel();
            lblInformacoes = new Label();
            lblDireitos = new Label();
            lblInstituicao = new Label();
            lblDesenvolvedores = new Label();
            pnlSobre.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(15, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(620, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestão de Vendas – Versão 1.0\r\n";
            lblTitulo.Click += lblIdentificacao_Click;
            // 
            // pnlSobre
            // 
            pnlSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSobre.Controls.Add(lblInformacoes);
            pnlSobre.Controls.Add(lblDireitos);
            pnlSobre.Controls.Add(lblInstituicao);
            pnlSobre.Controls.Add(lblDesenvolvedores);
            pnlSobre.Controls.Add(lblTitulo);
            pnlSobre.Location = new Point(12, 12);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(822, 403);
            pnlSobre.TabIndex = 1;
            pnlSobre.Paint += pnlSobre_Paint;
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacoes.Location = new Point(15, 66);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(806, 175);
            lblInformacoes.TabIndex = 6;
            lblInformacoes.Text = resources.GetString("lblInformacoes.Text");
            // 
            // lblDireitos
            // 
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireitos.Location = new Point(15, 361);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(335, 25);
            lblDireitos.TabIndex = 5;
            lblDireitos.Text = "© 2025 – Todos os direitos reservados.";
            // 
            // lblInstituicao
            // 
            lblInstituicao.AutoSize = true;
            lblInstituicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstituicao.Location = new Point(15, 336);
            lblInstituicao.Name = "lblInstituicao";
            lblInstituicao.Size = new Size(166, 25);
            lblInstituicao.TabIndex = 3;
            lblInstituicao.Text = "Instituição: IFNMG";
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesenvolvedores.Location = new Point(15, 261);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(297, 75);
            lblDesenvolvedores.TabIndex = 2;
            lblDesenvolvedores.Text = "Desenvolvido por:\nArtur Felipe dos Santos Gonçalves\nArthur Neres Barroso de Queiroz\n";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 427);
            Controls.Add(pnlSobre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            pnlSobre.ResumeLayout(false);
            pnlSobre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlSobre;
        private Label lblDesenvolvedores;
        private Label lblDireitos;
        private Label lblInstituicao;
        private Label lblInformacoes;
    }
}