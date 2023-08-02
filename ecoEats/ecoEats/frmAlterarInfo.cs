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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void frmAlterarInfo_Load(object sender, EventArgs e)
        {
            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Source Code Pro", 15, FontStyle.Regular);



            // Percorre todos os controles do formulário e aplica a fonte padrão
            AplicarFonteControles(this, fontePadrao);
            // Verifica se o formulário está maximizado

            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;



            // Ajusta a posição do formulário
            groupBox1.Location = new Point(x, y);
            label5.Font = new Font("Source Code Pro", 20, FontStyle.Regular);

        }
        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;



            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string senha1 = txtNsenha.Text;
            string senha2 = txtRsenha.Text;
            bool senhasConferem = (senha1 == senha2);

            if (senhasConferem)
            {
                string confirmação = "";

                if (rbtnEmail.Checked)
                {
                    confirmação = "Email";
                    MessageBox.Show("Código de verificação enviado por email");
                }
                else
                {
                    confirmação = "celular";
                    MessageBox.Show("Número de verificação enviado por SMS");
                }
            }
            else
            {
                MessageBox.Show("As senhas não conferem");
            }

            string email = lblEmail.Text;

            string novasenha = lblNSenha.Text;

            string recuperasenha = lblRsenha.Text;

            string confirmasenha = lblConfirm.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNsenha.UseSystemPasswordChar)
            {
                txtNsenha.UseSystemPasswordChar = false;
                txtRsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNsenha.UseSystemPasswordChar = true;
                txtRsenha.UseSystemPasswordChar = true;
            }

        }


        private void txtNsenha_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtRsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCelular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
