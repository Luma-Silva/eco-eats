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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            // Redireciona para a tela da ana
            MessageBox.Show("Tela em construção!");

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string documento = txtCPF_CNPJ.Text;
            string senha = txtSenha.Text;
            if (documento == "" || senha == "")
            {
                if (documento == "" && senha == "")
                {
                    txtCPF_CNPJ.BackColor = Color.Tomato;
                    txtSenha.BackColor = Color.Tomato;
                }

                else if (documento == "")
                {
                    txtCPF_CNPJ.BackColor = Color.Tomato;
                }
                else if (senha == "")
                {
                    txtSenha.BackColor = Color.Tomato;
                }
                MessageBox.Show("Preencha todos os campos!!");
                txtCPF_CNPJ.BackColor = Color.White;
                txtSenha.BackColor = Color.White;
                return;
            }
        }

        private void picMostrarEsconder_Click(object sender, EventArgs e)
        {
            bool mostrar = txtSenha.UseSystemPasswordChar;
            if (mostrar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                picMostrarEsconder.BackgroundImage = Properties.Resources.hide;
                mostrar = false;
            }
            else if (mostrar == false)
            {
                txtSenha.UseSystemPasswordChar = true;
                picMostrarEsconder.BackgroundImage = Properties.Resources.view;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
            
            
        }
    }
}
