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
    public partial class Pagamentos : Form
    {
        private static Pagamentos _instance;

        #region SingleTon
        public static Pagamentos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Pagamentos();
            }
            return _instance;
        }
        #endregion
        public Pagamentos()
        {
            InitializeComponent();
        }

        private void btnIniciarPagamento_Click(object sender, EventArgs e)
        {
            PagamentoFinal janela = PagamentoFinal.GetInstance();
            janela.ShowDialog(this);
            janela.BringToFront();
            janela.Focus();
        }
    }
}
