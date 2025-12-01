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

        // Exponho o usuário logado para telas que precisam persistir relacionamentos (ex.: Vendas)
        public static Usuario? LoggedUser { get; private set; }


        private Sistema(Usuario usuario)
        {
            InitializeComponent();

            // guarda referência do usuário logado
            LoggedUser = usuario;

            Text = "Sistema /" + usuario.Nome;
            //mnuCadastro.Enabled = usuario.Credencial.Perfil;

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
                staBarraEstadoUltimoAcesso.Visible = false;

            _credencial = UsuarioRepository.FindByIdWithCredencial(usuario.Id)?.Credencial;

            staBarraEstadoUltimoAcesso.Text = $"Último Acesso: {_credencial.UltimoAcesso}";

            // configura acesso aos menus conforme perfil do usuário logado
            ConfigureMenuAccess();
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
            // garante que menus respeitam o perfil também quando o formulário carrega
            ConfigureMenuAccess();
        }
        private void mnuRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagamentoFinal pagamentos = PagamentoFinal.GetInstance();
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

        // --- Novo método: configura acesso aos menus conforme Perfil ---
        private void ConfigureMenuAccess()
        {
            // Se não houver usuário logado, desabilita tudo exceto Sair e Ajuda
            if (LoggedUser == null || LoggedUser.Credencial == null)
            {
                mnuArquivo.Enabled = true;
                mnuArquivoSair.Enabled = true;

                mnuCadastro.Enabled = false;
                mnuCadastroUsuario.Enabled = false;
                mnuCadastroCliente.Enabled = false;

                catálogoToolStripMenuItem.Enabled = false;
                produtosToolStripMenuItem.Enabled = false;
                categoriasToolStripMenuItem.Enabled = false;

                mnuRelatorio.Enabled = false;
                mnuOrçamento.Enabled = false;
                compraToolStripMenuItem.Enabled = false;

                mnuCaixa.Enabled = false;
                mnuCaixaPagamento.Enabled = false;

                mnuAjuda.Enabled = true;
                mnuAjudaSobre.Enabled = true;

                return;
            }

            var perfil = LoggedUser.Credencial.Perfil;

            // Primeiro desabilita tudo por padrão
            mnuArquivo.Enabled = true;
            mnuArquivoSair.Enabled = true;

            mnuCadastro.Enabled = false;
            mnuCadastroUsuario.Enabled = false;
            mnuCadastroCliente.Enabled = false;

            catálogoToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            categoriasToolStripMenuItem.Enabled = false;

            mnuRelatorio.Enabled = false;
            mnuRelatorioFuncionarios.Enabled = false;
            mnuRelatorioVendas.Enabled = false;
            mnuRelatorioComissao.Enabled = false;
            mnuRelatorioProdutos.Enabled = false;

            mnuOrçamento.Enabled = false;
            compraToolStripMenuItem.Enabled = false;

            mnuCaixa.Enabled = false;
            mnuCaixaPagamento.Enabled = false;

            mnuAjuda.Enabled = true;
            mnuAjudaSobre.Enabled = true;

            // Concede permissões conforme perfil
            switch (perfil)
            {
                case Perfil.GERENTE:
                    // acesso total
                    mnuCadastro.Enabled = true;
                    mnuCadastroUsuario.Enabled = true;
                    mnuCadastroCliente.Enabled = true;

                    catálogoToolStripMenuItem.Enabled = true;
                    produtosToolStripMenuItem.Enabled = true;
                    categoriasToolStripMenuItem.Enabled = true;

                    mnuRelatorio.Enabled = true;
                    mnuRelatorioFuncionarios.Enabled = true;
                    mnuRelatorioVendas.Enabled = true;
                    mnuRelatorioComissao.Enabled = true;
                    mnuRelatorioProdutos.Enabled = true;

                    mnuOrçamento.Enabled = true;
                    compraToolStripMenuItem.Enabled = true;

                    mnuCaixa.Enabled = true;
                    mnuCaixaPagamento.Enabled = true;
                    break;

                case Perfil.VENDEDOR:
                    // arquivo -> sair (sempre)
                    // cadastro: só cliente
                    mnuCadastro.Enabled = true;
                    mnuCadastroUsuario.Enabled = false;
                    mnuCadastroCliente.Enabled = true;

                    // catálogo: não
                    catálogoToolStripMenuItem.Enabled = false;

                    // relatórios: não
                    mnuRelatorio.Enabled = false;

                    // orçamento (compra): sim
                    mnuOrçamento.Enabled = true;
                    compraToolStripMenuItem.Enabled = true;

                    // caixa pagamento: não
                    mnuCaixa.Enabled = false;

                    // ajuda: sim (já habilitado)
                    break;

                case Perfil.OPERADOR_CAIXA:
                    // arquivo -> sair
                    // cadastro: não
                    mnuCadastro.Enabled = false;

                    // catálogo: não
                    catálogoToolStripMenuItem.Enabled = false;

                    // relatórios: não
                    mnuRelatorio.Enabled = false;

                    // orçamento: não
                    mnuOrçamento.Enabled = false;

                    // caixa: sim
                    mnuCaixa.Enabled = true;
                    mnuCaixaPagamento.Enabled = true;

                    // ajuda: sim (já habilitado)
                    break;

                default:
                    // comportamento por omissão: perfil com menos privilégios
                    break;
            }
        }
    }
}
