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
            lblOferece = new Label();
            lblOferecimentos = new Label();
            lblInformacoes = new Label();
            lblInformacao = new Label();
            lblDireitos = new Label();
            lblAno = new Label();
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
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(15, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(644, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestão de Usuários – Versão 1.0\n";
            lblTitulo.Click += lblIdentificacao_Click;
            // 
            // pnlSobre
            // 
            pnlSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSobre.Controls.Add(lblOferece);
            pnlSobre.Controls.Add(lblOferecimentos);
            pnlSobre.Controls.Add(lblInformacoes);
            pnlSobre.Controls.Add(lblInformacao);
            pnlSobre.Controls.Add(lblDireitos);
            pnlSobre.Controls.Add(lblAno);
            pnlSobre.Controls.Add(lblInstituicao);
            pnlSobre.Controls.Add(lblDesenvolvedores);
            pnlSobre.Controls.Add(lblTitulo);
            pnlSobre.Location = new Point(12, 12);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(687, 358);
            pnlSobre.TabIndex = 1;
            pnlSobre.Paint += pnlSobre_Paint;
            // 
            // lblOferece
            // 
            lblOferece.AutoSize = true;
            lblOferece.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOferece.Location = new Point(15, 142);
            lblOferece.Name = "lblOferece";
            lblOferece.Size = new Size(394, 25);
            lblOferece.TabIndex = 9;
            lblOferece.Text = "com autenticação segura e interface intuitiva.\n";
            // 
            // lblOferecimentos
            // 
            lblOferecimentos.AutoSize = true;
            lblOferecimentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOferecimentos.Location = new Point(15, 117);
            lblOferecimentos.Name = "lblOferecimentos";
            lblOferecimentos.Size = new Size(603, 25);
            lblOferecimentos.TabIndex = 8;
            lblOferecimentos.Text = "O sistema oferece recursos para gerenciamento completo de usuários,";
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacoes.Location = new Point(15, 92);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(391, 50);
            lblInformacoes.TabIndex = 7;
            lblInformacoes.Text = "Entity Framework para persistência de dados.\n\n";
            // 
            // lblInformacao
            // 
            lblInformacao.AutoSize = true;
            lblInformacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacao.Location = new Point(15, 67);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(669, 25);
            lblInformacao.TabIndex = 6;
            lblInformacao.Text = "Aplicação desenvolvida em C# (.NET Framework) utilizando Windows Forms e ";
            lblInformacao.Click += lblInformações_Click;
            // 
            // lblDireitos
            // 
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireitos.Location = new Point(15, 319);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(335, 25);
            lblDireitos.TabIndex = 5;
            lblDireitos.Text = "© 2025 – Todos os direitos reservados.";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(15, 294);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(95, 25);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano: 2025\n";
            // 
            // lblInstituicao
            // 
            lblInstituicao.AutoSize = true;
            lblInstituicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstituicao.Location = new Point(15, 269);
            lblInstituicao.Name = "lblInstituicao";
            lblInstituicao.Size = new Size(166, 25);
            lblInstituicao.TabIndex = 3;
            lblInstituicao.Text = "Instituição: IFNMG";
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesenvolvedores.Location = new Point(15, 194);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(297, 75);
            lblDesenvolvedores.TabIndex = 2;
            lblDesenvolvedores.Text = "Desenvolvido por:\nArtur Felipe dos Santos Gonçalves\nArthur Neres Barroso de Queiroz\n";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 382);
            Controls.Add(pnlSobre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private Label lblAno;
        private Label lblInstituicao;
        private Label lblInformacao;
        private Label lblInformacoes;
        private Label lblOferece;
        private Label lblOferecimentos;
    }
}