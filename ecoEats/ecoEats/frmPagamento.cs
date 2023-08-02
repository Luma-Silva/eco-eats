using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
                "Nome No Cartão:" + NomeNoCartão + "\n" +
                "Número Do Cartão:" + NúmeroDoCartão + "\n" +
                "Código:" + Código + "\n" +
                "Data De Validade:" + DataDeValidade + "\n" +
                "Tipo de pagamento:" + Tipodopagamento);

        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Arial", 14, FontStyle.Regular);



            // Percorre todos os controles do formulário e aplica a fonte padrão
            AplicarFonteControles(this, fontePadrao);
            // Verifica se o formulário está maximizado

            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;



            // Ajusta a posição do formulário
            groupBox1.Location = new Point(x, y);
        }

        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;



            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }
    }
    }
