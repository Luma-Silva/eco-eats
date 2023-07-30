using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecoEats
{
    public partial class frmCodigoBarras : Form
    {
        public frmCodigoBarras()
        {
            InitializeComponent();
        }

        private void frmCodigoBarras_Load(object sender, EventArgs e)
        {

        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string cod = textBoxDigCod.Text;
            if (cod == "")
            {
                MessageBox.Show("Digite algum código de barras");
                return;
            }

            MessageBox.Show("Código:" + cod);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnDigiteCod_Click(object sender, EventArgs e)
        {

        }
    }
}
