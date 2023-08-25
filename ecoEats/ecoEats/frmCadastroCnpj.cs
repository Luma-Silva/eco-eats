using ecoEats.Properties;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ecoEats.Models;

namespace ecoEats
{
    public partial class frmCadastroCnpj : Form
    {
        public frmCadastroCnpj()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cnpj = mkdTCnpj.Text;
            string razao = txtRazao.Text;
            string nome = txtName.Text;
            string rua = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mdkTCep.Text;
            string estado = txtEstado.Text;
            string telefone = mkdTTelefone.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmarsenha = txtCSenha.Text;
            string cidade = txtCidade.Text;
            
            if (cnpj == "" || razao == "" || nome == "" || rua == "" || numero == "" || bairro == "" || cep == "" || cidade == ""|| estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "" || rdbConfirmar.Checked==false)
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
                if (rua == "")
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
                if (cidade == "")
                {
                    txtCidade.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtCidade.BackColor = Color.White;
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
                if (cnpj == "" || razao == "" || nome == "" || rua == "" || numero == "" || bairro == "" || cep == "" || cidade == "" || estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "")
                    {
                    MessageBox.Show("Preencha todos os campos!");
                    }
                if (rdbConfirmar.Checked == false)
                {
                    MessageBox.Show("Confirme a veracidade dos dados!");
                }
            }
            else
            {    
                if (txtCSenha.Text != txtSenha.Text)
                {
                    MessageBox.Show("Senhas diferentes!");
                    txtSenha.BackColor = Color.PaleVioletRed;
                    txtCSenha.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    MessageBox.Show("Cadastro concluído");
                    Form home = new frmHome();
                    home.Show();
                    this.Hide();
                }              
                             
            }
            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO usuarios (nome, email, telefone, senha) VALUES (@pnome, @pemail, @ptelefone, @psenha);";

                var parameters = new[]

                {

                    new MySqlParameter("@pnome", nome),

                    new MySqlParameter("@pemail", email),

                    new MySqlParameter("@ptelefone", telefone),

                    new MySqlParameter("@psenha", senha)
                };


                /*query += @"INSERT INTO pessoas_juridicas (cnpj, razao_social, fk_pj_user) VALUES (@cnpj, @razao_social, fk_pj_user);";

                var parameters = new[]

                {

                    new MySqlParameter("@cnpj", cnpj),

                    new MySqlParameter("@razao_social", razao),

                    new MySqlParameter("@fk_pj_user", ) 
                };
                
                query += @"INSERT INTO enderecos (rua, numero, cep, cidade, bairro, fk_end_user) VALUES (@prua, @pnumero, @pcep, @cidade, @pbairro, fk_end_user);";

                var parameters = new[]

                {

                    new MySqlParameter("@prua", rua),

                    new MySqlParameter("@pnumero", numero),

                    new MySqlParameter("@pcep", cep),

                    new MySqlParameter("@pcidade", cidade),
                    
                    new MySqlParameter("@pbairro", bairro),
                  
                    new MySqlParameter("fk_end_user
                };*/

                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

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
        private void button1_Click(object sender, EventArgs e)
        {         
            Form principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmCadastroCnpj_Load(object sender, EventArgs e)
        {
           Font fontePadrao = new Font("Nirmala Ui", 12 , FontStyle.Bold);
           AplicarFonteControles(this, fontePadrao);
           int x = (Screen.PrimaryScreen.WorkingArea.Width - gBPrincipal.Width) / 2;
           int y = (Screen.PrimaryScreen.WorkingArea.Height - gBPrincipal.Height) / 2;
           gBPrincipal.Location = new Point(x, y);
           lblDados.Font = new Font("Nirmala Ui", 16, FontStyle.Bold);
        }
        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;
            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }

        private void pbCSenha_Click(object sender, EventArgs e)
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
            
        }

        private void pbCSenha2_Click(object sender, EventArgs e)
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

        private void gBPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
