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
    public partial class RelatorioVendas : Form
    {
        private static RelatorioVendas _instance;
        public RelatorioVendas()
        {
            InitializeComponent();
            lsvVendas.Clear();

            lsvVendas.View = View.Details;
            lsvVendas.FullRowSelect = true;
            lsvVendas.GridLines = true;
            lsvVendas.Columns.Add("ID", 70);
            lsvVendas.Columns.Add("Cliente", 180);
            lsvVendas.Columns.Add("Vendedor", 180);
            lsvVendas.Columns.Add("Data Efetivação", 110);
            lsvVendas.Columns.Add("Total Pago", 120);

            lsvVendas.Enabled = true;
        }
        public static RelatorioVendas GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioVendas();
            }
            return _instance;
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpDataInicial.Value;
            DateTime dataFim = dtpDataFinal.Value;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("Data de início não pode ser maior que a data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            List<Compra> compras = CompraRepository.GetConcludedPerPeriod(dataInicio, dataFim);


            lsvVendas.BeginUpdate();
            lsvVendas.Items.Clear();

            foreach (Compra compra in compras)
            {
                String clienteNome = compra.Cliente?.Nome ?? "[sem cliente]";
                String vendedorNome = compra.Vendedor?.Nome ?? "[sem vendedor]";
                String dataEfetivacao = compra.Efetivacao.HasValue ? compra.Efetivacao.Value.ToString("dd/MM/yyyy") : "-";

                String totalPago = compra.CalcularTotal().ToString("C2");

                ListViewItem lsv = new ListViewItem(compra.Id.ToString());
                lsv.SubItems.Add(clienteNome);
                lsv.SubItems.Add(vendedorNome);
                lsv.SubItems.Add(dataEfetivacao);
                lsv.SubItems.Add(totalPago);

                lsvVendas.Items.Add(lsv);
            }

            lsvVendas.EndUpdate();

            txtTotalVendas.Text = compras.Count.ToString();
            txtValorTotal.Text = compras.Sum(c => c.CalcularTotal()).ToString("C2");
        }
    }
}
