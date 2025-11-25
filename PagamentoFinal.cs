using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_TCD
{
    public partial class PagamentoFinal : Form
    {
        private static PagamentoFinal? _instance;

        #region SingleTon
        public static PagamentoFinal GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PagamentoFinal();
            }
            return _instance;
        }
        #endregion
        public PagamentoFinal()
        {
            InitializeComponent();
        }
    }
}
