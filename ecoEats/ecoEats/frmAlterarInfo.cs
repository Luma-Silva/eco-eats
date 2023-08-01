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
    }
}
