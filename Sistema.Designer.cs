namespace Trabalho1_ProgVis
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            menuStrip1 = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuCadastroCliente = new ToolStripMenuItem();
            catálogoToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioFuncionarios = new ToolStripMenuItem();
            mnuOrçamento = new ToolStripMenuItem();
            compraToolStripMenuItem = new ToolStripMenuItem();
            mnuCaixa = new ToolStripMenuItem();
            mnuCaixaPagamento = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            staBarraEstado = new StatusStrip();
            staBarraEstadoUltimoAcesso = new ToolStripStatusLabel();
            mnuRelatorioVendas = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            staBarraEstado.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, catálogoToolStripMenuItem, mnuRelatorio, mnuOrçamento, mnuCaixa, mnuAjuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArquivoSair });
            mnuArquivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuArquivo.Image = Trabalho_TCD.Properties.Resources.File;
            mnuArquivo.ImageScaling = ToolStripItemImageScaling.None;
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(147, 54);
            mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.BackColor = SystemColors.ControlDarkDark;
            mnuArquivoSair.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuArquivoSair.Image = Trabalho_TCD.Properties.Resources.icons8_close_50;
            mnuArquivoSair.ImageScaling = ToolStripItemImageScaling.None;
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(154, 56);
            mnuArquivoSair.Text = "Sair";
            mnuArquivoSair.Click += mnuArquivoSair_Click;
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuario, mnuCadastroCliente });
            mnuCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuCadastro.Image = Trabalho_TCD.Properties.Resources.Plus;
            mnuCadastro.ImageScaling = ToolStripItemImageScaling.None;
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(157, 54);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroUsuario
            // 
            mnuCadastroUsuario.BackColor = SystemColors.ControlDarkDark;
            mnuCadastroUsuario.Image = Trabalho_TCD.Properties.Resources.icons8_add_user_male_50;
            mnuCadastroUsuario.ImageScaling = ToolStripItemImageScaling.None;
            mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            mnuCadastroUsuario.Size = new Size(190, 56);
            mnuCadastroUsuario.Text = "Usuário";
            mnuCadastroUsuario.Click += mnuCadastroUsuario_Click;
            // 
            // mnuCadastroCliente
            // 
            mnuCadastroCliente.BackColor = SystemColors.ControlDarkDark;
            mnuCadastroCliente.Image = Trabalho_TCD.Properties.Resources.icons8_card_payment_50;
            mnuCadastroCliente.ImageScaling = ToolStripItemImageScaling.None;
            mnuCadastroCliente.Name = "mnuCadastroCliente";
            mnuCadastroCliente.Size = new Size(190, 56);
            mnuCadastroCliente.Text = "Cliente";
            mnuCadastroCliente.Click += mnuCadastroCliente_Click;
            // 
            // catálogoToolStripMenuItem
            // 
            catálogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, categoriasToolStripMenuItem });
            catálogoToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catálogoToolStripMenuItem.Image = Trabalho_TCD.Properties.Resources.Bookmark;
            catálogoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            catálogoToolStripMenuItem.Size = new Size(158, 54);
            catálogoToolStripMenuItem.Text = "Catálogo";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            produtosToolStripMenuItem.Image = Trabalho_TCD.Properties.Resources.icons8_products_50;
            produtosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(218, 56);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            categoriasToolStripMenuItem.Image = Trabalho_TCD.Properties.Resources.icons8_categories_50;
            categoriasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(218, 56);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioFuncionarios, mnuRelatorioVendas });
            mnuRelatorio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuRelatorio.Image = Trabalho_TCD.Properties.Resources.Document;
            mnuRelatorio.ImageScaling = ToolStripItemImageScaling.None;
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(149, 54);
            mnuRelatorio.Text = "Relatório";
            mnuRelatorio.Click += mnuRelatorio_Click;
            // 
            // mnuRelatorioFuncionarios
            // 
            mnuRelatorioFuncionarios.BackColor = SystemColors.ControlDarkDark;
            mnuRelatorioFuncionarios.Image = Trabalho_TCD.Properties.Resources.icons8_users_50;
            mnuRelatorioFuncionarios.ImageScaling = ToolStripItemImageScaling.None;
            mnuRelatorioFuncionarios.Name = "mnuRelatorioFuncionarios";
            mnuRelatorioFuncionarios.Size = new Size(226, 56);
            mnuRelatorioFuncionarios.Text = "Funcionários";
            mnuRelatorioFuncionarios.Click += mnuRelatorioUsuarios_Click;
            // 
            // mnuOrçamento
            // 
            mnuOrçamento.DropDownItems.AddRange(new ToolStripItem[] { compraToolStripMenuItem });
            mnuOrçamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuOrçamento.Image = Trabalho_TCD.Properties.Resources.icons8_vendedor_50;
            mnuOrçamento.ImageScaling = ToolStripItemImageScaling.None;
            mnuOrçamento.Name = "mnuOrçamento";
            mnuOrçamento.Size = new Size(168, 54);
            mnuOrçamento.Text = "Orçamento";
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            compraToolStripMenuItem.Image = Trabalho_TCD.Properties.Resources.icons8_comprar_50;
            compraToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(185, 56);
            compraToolStripMenuItem.Text = "Compra";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // mnuCaixa
            // 
            mnuCaixa.DropDownItems.AddRange(new ToolStripItem[] { mnuCaixaPagamento });
            mnuCaixa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuCaixa.Image = Trabalho_TCD.Properties.Resources.icons8_caixa_50;
            mnuCaixa.ImageScaling = ToolStripItemImageScaling.None;
            mnuCaixa.Name = "mnuCaixa";
            mnuCaixa.Size = new Size(120, 54);
            mnuCaixa.Text = "Caixa";
            // 
            // mnuCaixaPagamento
            // 
            mnuCaixaPagamento.BackColor = SystemColors.ControlDarkDark;
            mnuCaixaPagamento.Image = Trabalho_TCD.Properties.Resources.icons8_card_payment_50;
            mnuCaixaPagamento.ImageScaling = ToolStripItemImageScaling.None;
            mnuCaixaPagamento.Name = "mnuCaixaPagamento";
            mnuCaixaPagamento.Size = new Size(213, 56);
            mnuCaixaPagamento.Text = "Pagamento";
            mnuCaixaPagamento.Click += pagamentoToolStripMenuItem_Click;
            // 
            // mnuAjuda
            // 
            mnuAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAjudaSobre });
            mnuAjuda.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuAjuda.Image = Trabalho_TCD.Properties.Resources.icons8_help_50__2_;
            mnuAjuda.ImageScaling = ToolStripItemImageScaling.None;
            mnuAjuda.Name = "mnuAjuda";
            mnuAjuda.Size = new Size(129, 54);
            mnuAjuda.Text = "Ajuda";
            // 
            // mnuAjudaSobre
            // 
            mnuAjudaSobre.BackColor = SystemColors.ControlDarkDark;
            mnuAjudaSobre.Image = Trabalho_TCD.Properties.Resources.Info;
            mnuAjudaSobre.ImageScaling = ToolStripItemImageScaling.None;
            mnuAjudaSobre.Name = "mnuAjudaSobre";
            mnuAjudaSobre.Size = new Size(173, 56);
            mnuAjudaSobre.Text = "Sobre";
            mnuAjudaSobre.Click += mnuAjudaSobre_Click;
            // 
            // staBarraEstado
            // 
            staBarraEstado.Items.AddRange(new ToolStripItem[] { staBarraEstadoUltimoAcesso });
            staBarraEstado.Location = new Point(0, 523);
            staBarraEstado.Name = "staBarraEstado";
            staBarraEstado.Size = new Size(1106, 22);
            staBarraEstado.TabIndex = 1;
            staBarraEstado.Text = "statusStrip1";
            // 
            // staBarraEstadoUltimoAcesso
            // 
            staBarraEstadoUltimoAcesso.Name = "staBarraEstadoUltimoAcesso";
            staBarraEstadoUltimoAcesso.Size = new Size(118, 17);
            staBarraEstadoUltimoAcesso.Text = "toolStripStatusLabel1";
            // 
            // mnuRelatorioVendas
            // 
            mnuRelatorioVendas.BackColor = SystemColors.ControlDarkDark;
            mnuRelatorioVendas.Image = Trabalho_TCD.Properties.Resources.icons8_sales_50;
            mnuRelatorioVendas.ImageScaling = ToolStripItemImageScaling.None;
            mnuRelatorioVendas.Name = "mnuRelatorioVendas";
            mnuRelatorioVendas.Size = new Size(226, 56);
            mnuRelatorioVendas.Text = "Vendas";
            mnuRelatorioVendas.Click += vendasToolStripMenuItem_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1106, 545);
            Controls.Add(staBarraEstado);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            WindowState = FormWindowState.Maximized;
            FormClosed += Sistema_FormClosed;
            Load += Sistema_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            staBarraEstado.ResumeLayout(false);
            staBarraEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroUsuario;
        private ToolStripMenuItem mnuRelatorio;
        private StatusStrip staBarraEstado;
        private ToolStripStatusLabel staBarraEstadoUltimoAcesso;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuAjudaSobre;
        private ToolStripMenuItem mnuRelatorioFuncionarios;
        private ToolStripMenuItem mnuCadastroCliente;
        private ToolStripMenuItem catálogoToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem mnuCaixa;
        private ToolStripMenuItem mnuCaixaPagamento;
        private ToolStripMenuItem mnuOrçamento;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem mnuRelatorioVendas;
    }
}