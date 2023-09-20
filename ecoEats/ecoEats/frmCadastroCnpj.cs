using ecoEats.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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


            if (cnpj == "" || razao == "" || nome == "" || rua == "" || numero == "" || bairro == "" || cep == "" || cidade == "" || estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "" || rdbConfirmar.Checked == false)
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
                    using (MyDbContext db = new MyDbContext())

                    {
                        string query = @"INSERT INTO usuarios (nome, email, telefone, senha) VALUES (@pnome, @pemail, @ptelefone, @psenha); SELECT LAST_INSERT_ID();";
                        var parameters = new[]

                        {
                    new MySqlParameter("@pnome", nome),

                    new MySqlParameter("@pemail", email),

                    new MySqlParameter("@ptelefone", telefone),

                    new MySqlParameter("@psenha", senha)
                  };
                        int newUserId = db.Database.SqlQuery<int>(query, parameters).Single();

                        query = "INSERT INTO pessoas_juridicas (cnpj, razao_social, fk_pj_user) VALUES ('" + cnpj + "', '" + razao + "', " + newUserId + ");";

                        db.Database.ExecuteSqlCommand(query);

                        query = @"INSERT INTO enderecos (rua, numero, cep, cidade, bairro, uf, fk_end_user) VALUES ('" + rua + "', '" + numero + "', '" + cep + "', '" + cidade + "', '" + bairro + "', '" + estado + "', " + newUserId + ");";

                        db.Database.ExecuteSqlCommand(query);
                        MessageBox.Show("Cadastro concluído");
                      frmLogin frm = new frmLogin();
                        this.Hide();
                        frm.Show();
                    }

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
        private void button1_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmCadastroCnpj_Load(object sender, EventArgs e)
        {
            Font fontePadrao = new Font("Nirmala Ui", 10, FontStyle.Bold);
            AplicarFonteControles(this, fontePadrao);
            int x = (Screen.PrimaryScreen.WorkingArea.Width - gBPrincipal.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - gBPrincipal.Height) / 2;
            gBPrincipal.Location = new Point(x, y);
            lblDados.Font = new Font("Nirmala Ui", 14, FontStyle.Bold);
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

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lbLTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
