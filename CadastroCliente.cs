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
    public partial class CadastroCliente : Form
    {
        private static CadastroCliente? _instance;
        public CadastroCliente()
        {
            InitializeComponent();
        }
        #region SingleTon

        public static CadastroCliente GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastroCliente();
            }
            return _instance;
        }
        #endregion
    }
}
