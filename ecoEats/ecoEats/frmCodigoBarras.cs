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
            Form mostrar = new Form();
            mostrar.Show();

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

        private void frmCodigoBarras_Load_1(object sender, EventArgs e)
        {
            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);



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
