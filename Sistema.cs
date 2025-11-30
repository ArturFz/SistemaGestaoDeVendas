using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_TCD;

namespace Trabalho1_ProgVis
{
    public partial class Sistema : Form
    {

        private static Sistema? _instance;

        private Credencial? _credencial;


        private Sistema(Usuario usuario)
        {
            InitializeComponent();

            Text = "Sistema /" + usuario.Nome;
            //mnuCadastro.Enabled = usuario.Credencial.Perfil;

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
                staBarraEstadoUltimoAcesso.Visible = false;

            _credencial = UsuarioRepository.FindByIdWithCredencial(usuario.Id)?.Credencial;

            staBarraEstadoUltimoAcesso.Text = $"Último Acesso: {_credencial.UltimoAcesso}";

        }

        #region SingleTon
        public static Sistema GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Sistema(usuario);
            }

            return _instance;
        }
        #endregion

        private void Sistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.GetInstance().Show();
            _credencial.UltimoAcesso = DateTime.Now;
            CredencialRepository.SaveOrUpdate(_credencial);
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
            Login.GetInstance().Show();
        }


        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastro = CadastroFuncionario.GetInstance();
            cadastro.MdiParent = this;
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;

            cadastro.Show();
        }

        private void mnuAjudaSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = Sobre.GetInstance();
            sobre.MdiParent = this;
            sobre.BringToFront();
            sobre.WindowState = FormWindowState.Normal;

            sobre.Show();
        }

        private void mnuRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            RelatorioFuncionarios listaUsuarios = RelatorioFuncionarios.GetInstance();
            listaUsuarios.MdiParent = this;
            listaUsuarios.BringToFront();
            listaUsuarios.WindowState = FormWindowState.Normal;

            listaUsuarios.Show();
        }

        private void mnuCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastro = CadastroCliente.GetInstance();
            cadastro.MdiParent = this;
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;

            cadastro.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos cadastro = Produtos.GetInstance();
            cadastro.MdiParent = this;
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;

            cadastro.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias cadastro = Categorias.GetInstance();
            cadastro.MdiParent = this;
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;

            cadastro.Show();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }
        private void mnuRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarPagamento pagamentos = IniciarPagamento.GetInstance();
            pagamentos.MdiParent = this;
            pagamentos.BringToFront();
            pagamentos.WindowState = FormWindowState.Normal;

            pagamentos.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas compras = Vendas.GetInstance();
            compras.MdiParent = this;
            compras.BringToFront();
            compras.WindowState = FormWindowState.Normal;

            compras.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorioVendas = RelatorioVendas.GetInstance();
            relatorioVendas.MdiParent = this;
            relatorioVendas.BringToFront();
            relatorioVendas.WindowState = FormWindowState.Normal;

            relatorioVendas.Show();
        }

        private void comToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioComissao relatorioComissao = RelatorioComissao.GetInstance();
            relatorioComissao.MdiParent = this;
            relatorioComissao.BringToFront();
            relatorioComissao.WindowState = FormWindowState.Normal;

            relatorioComissao.Show();
        }

        private void mnuRelatorioProdutos_Click(object sender, EventArgs e)
        {
            RelatorioProdutos relatorioProdutos = RelatorioProdutos.GetInstance();
            relatorioProdutos.MdiParent = this;
            relatorioProdutos.BringToFront();
            relatorioProdutos.WindowState = FormWindowState.Normal;

            relatorioProdutos.Show();
        }

        public static Usuario? GetUsuarioLogado()
        {
            return _usuario;
        }
    }
}
