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
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }
        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            string Tipodopagamento = "";
            if (ckbCredito.Checked)
            {
                Tipodopagamento = "Crédito";
            }
            else
            {
                Tipodopagamento = "Débito";
            }
            string CPF = txtCpf.Text;

            string NomeNoCartão = txtNomeNoCartao.Text;

            string NúmeroDoCartão = txtNumeroDoCartao.Text;

            string Código = txtCodigo.Text;

            string DataDeValidade = dtpDataDeValidade.Value.ToString("MM-yy");

            MessageBox.Show("CPF:" + CPF + "\n" +
                "NomeNoCartão:" + NomeNoCartão + "\n" +
                "NúmeroDoCartão:" + NúmeroDoCartão + "\n" +
                "Código:" + Código + "\n" +
                "DataDeValidade:" + DataDeValidade + "\n" +
                "Tipodepagamento:" + Tipodopagamento);

        }
    }
}
