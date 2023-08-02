using ecoEats.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                pbCSenha2.Image = Resources.view;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pbCSenha2.Image = Resources.hide;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtCSenha_TextChanged(object sender, EventArgs e)
        {

            if (txtCSenha.PasswordChar == '*')
            {
                txtCSenha.PasswordChar = '\0';
                pbCSenha.Image = Resources.view;
                txtCSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtCSenha.PasswordChar = '*';
                pbCSenha.Image = Resources.hide;
                txtCSenha.UseSystemPasswordChar = false;
            }
            if (txtCSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("Senha cadastrada");
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
                if (cnpj == "")
                {
                    mkdTCnpj.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    mkdTCnpj.BackColor = Color.White;
                }
                if (razao == "")
                {
                    txtRazao.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtRazao.BackColor = Color.White;
                }
                if (nome == "")
                {
                    txtName.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtName.BackColor = Color.White;
                }
                if (endereco == "")
                {
                    txtEndereco.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtEndereco.BackColor = Color.White;
                }
                if (numero == "")
                {
                    txtNumero.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtNumero.BackColor = Color.White;
                }
                if (bairro == "")
                {
                    txtBairro.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtBairro.BackColor = Color.White;
                }                
                if (cep == "")
                {
                    mdkTCep.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    mdkTCep.BackColor = Color.White;
                }
                if (estado == "")
                {
                    txtEstado.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtEstado.BackColor = Color.White;
                }
                if (telefone == "")
                {
                    mkdTTelefone.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    mkdTTelefone.BackColor = Color.White;
                }
                if (email == "")
                {
                    txtEmail.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtEmail.BackColor = Color.White;

                }
                if (senha == "")
                {
                    txtSenha.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtSenha.BackColor = Color.White;

                }
                if (confirmarsenha == "")
                {
                    txtCSenha.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtCSenha.BackColor = Color.White;

                }
                if (cnpj == "" || razao == "" || nome == "" || endereco == "" || numero == "" || bairro == "" || cep == "" || estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "")
                    {
                    MessageBox.Show("Preencha todos os campos!");
                    }
            }
            else
            {    
                if (txtCSenha.Text != txtSenha.Text)
                {
                    MessageBox.Show("Senhas diferentes!");
                    BackColor = Color.PaleVioletRed;
                }
                else
                {
                    MessageBox.Show("Cadastro concluído");
                }
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {

            {
                string email = txtEmail.Text;
                Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                if (!regex.IsMatch(email))
                {
                    MessageBox.Show("Email inválido!");
                    txtEmail.BackColor = Color.PaleVioletRed;
                }
            }
        }

        private void lbLTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblUf_Click(object sender, EventArgs e)
        {

        }

        private void rdbConfirmar_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
