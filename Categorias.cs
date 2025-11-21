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
    public partial class Categorias : Form
    {
        private static Categorias? _instance;
        

        public Categorias()
        {
            InitializeComponent();
        }

        #region SingleTon
        public static Categorias GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Categorias();
            }
            return _instance;
        }
        #endregion
        public Categorias()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

    }
}
