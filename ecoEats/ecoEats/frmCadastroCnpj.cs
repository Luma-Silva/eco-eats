using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ecoEats
{
    public partial class frmCadastroCnpj : Form
    {
        public frmCadastroCnpj()
        {
            InitializeComponent();
        }

        private void frmCadastroCnpj_Load(object sender, EventArgs e)
        {

        }
        private void mkdTCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cnpj = mkdTCnpj.Text;
            if (cnpj == "")
            {
                mkdTCnpj.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mkdTCnpj.BackColor = Color.White;

            }
        }

        private void txtRazao_TextChanged(object sender, EventArgs e)
        {
            string razao = txtRazao.Text;
            if (razao == "")
            {
                txtRazao.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtRazao.BackColor = Color.White;

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string nome = txtName.Text;

            if (nome == "")
            {
                txtName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            string endereco = txtEndereco.Text;
            if (endereco == "")
            {
                txtEndereco.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtEndereco.BackColor = Color.White;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            if (numero == "")
            {
                txtNumero.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtNumero.BackColor = Color.White;
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            string bairro = txtBairro.Text;
            if (bairro == "")
            {
                txtBairro.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBairro.BackColor = Color.White;
            }
        }

        private void mdkTCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cep = mdkTCep.Text;
            if (cep == "")
            {
                mdkTCep.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mdkTCep.BackColor = Color.White;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            string estado = txtEstado.Text;
            if (estado == "")
            {
                txtEstado.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtEstado.BackColor = Color.White;
            }
        }

        private void mkdTTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string telefone = mkdTTelefone.Text;
            if (telefone == "")
            {
                mkdTTelefone.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mkdTTelefone.BackColor = Color.White;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email == "")
            {
                txtEmail.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtEmail.BackColor = Color.White;

            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtCSenha_TextChanged(object sender, EventArgs e)
        {

            if (txtCSenha.PasswordChar == '*')
            {
                txtCSenha.PasswordChar = '\0';
                pbCSenha.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtCSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtCSenha.PasswordChar = '*';
                pbCSenha.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtCSenha.UseSystemPasswordChar = false;
            }
            if (txtCSenha.Text == txtSenha.Text)
            {
                MessageBox.Show("Senha cadastrada!");
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string cnpj = mkdTCnpj.Text;
            string razao = txtRazao.Text;
            string nome = txtName.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mdkTCep.Text;
            string estado = txtEstado.Text;
            string telefone = mkdTTelefone.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmarsenha = txtCSenha.Text;
            string dados = rdbConfirmar.Text;
            if (cnpj == "" || razao == "" || nome == "" || endereco == "" || numero == "" || bairro == "" || cep == "" || estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "")
            {
                MessageBox.Show("Prencha todos os campos!");
            }
            else
            {
                if (txtCSenha.Text != txtSenha.Text)
                {
                    MessageBox.Show("Senhas diferentes!");
                }

                else
                {
                    MessageBox.Show("Cadastro concluído");
                }
            }
        }
    }
}
