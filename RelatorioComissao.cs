using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public partial class RelatorioComissao : Form
    {
        private static RelatorioComissao? _instance;
        private Usuario? _vendedorSelecionado;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        public RelatorioComissao()
        {
            InitializeComponent();
            cboVendedor.Items.Clear();

            List<Usuario> vendedores = UsuarioRepository.FindAllWithCredencial()
        .Where(u => u?.Credencial?.Perfil == Perfil.VENDEDOR)
        .ToList();

            cboVendedor.DataSource = vendedores;
            cboVendedor.DisplayMember = "Nome";
            cboVendedor.SelectedIndex = -1;
        }
        public static RelatorioComissao GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioComissao();
            }
            return _instance;
        }

        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            _vendedorSelecionado = cboVendedor.SelectedItem as Usuario;

            _dataInicio = dtpDataInicial.Value;
            _dataFim = dtpDataInicial.Value;

            if (_vendedorSelecionado == null)
            {
                MessageBox.Show("Selecione um vendedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_dataInicio > _dataFim)
            {
                MessageBox.Show("Data de início não pode ser maior que a data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Compra> compras = CompraRepository.GetPerPeriodAndVendedor(_dataInicio, _dataFim, _vendedorSelecionado.Id);
            Decimal comissaoTotal = 0m;
            foreach (Compra compra in compras)
            {
                comissaoTotal += compra.CalcularComissao();
            }
            txtComissaoTotal.Text = comissaoTotal.ToString("C2");
        }

        private void cboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVendedor.SelectedItem == null)
            {
                LimparCampos();
                return;
            }
            _vendedorSelecionado = cboVendedor.SelectedItem as Usuario;

            if (_vendedorSelecionado is Vendedor vendedor)
            {
                txtMatricula.Text = vendedor.Matricula.ToString();
            }
            else
            {
                txtMatricula.Text = "N/A (Gerente)";
            }

            txtNome.Text = _vendedorSelecionado.Nome;
            txtEmail.Text = _vendedorSelecionado.Email;
        }

        private void LimparCampos()
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtComissaoTotal.Clear();
            _vendedorSelecionado = null;
        }
    }
}
