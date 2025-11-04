using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1_ProgVis
{
    public partial class Sobre : Form
    {
        private static Sobre _instance;

        #region SingleTon
        public static Sobre GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Sobre();
            }

            return _instance;
        }
        #endregion

        public Sobre()
        {
            InitializeComponent();
        }

        private void pnlSobre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInformações_Click(object sender, EventArgs e)
        {

        }

        private void lblIdentificacao_Click(object sender, EventArgs e)
        {

        }
    }
}
