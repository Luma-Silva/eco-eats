using ecoEats.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;

using MySql.Data.MySqlClient;
using System.Xml.Linq;

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
          
           frmAlterarSenha frm = new frmAlterarSenha(true);
           this.Hide();
           frm.FormBorderStyle = FormBorderStyle.Sizable;

            frm.Show();

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
            using (MyDbContext db = new MyDbContext())
            {

                string query = "SELECT u.id, u.nome" +
                    "FROM  usuarios AS u ";
                if (documento.Length == 14 || documento.Length==11) {
                    query += "JOIN pessoas_fisicas AS pf ON pf.fk_pf_user=u.id AND pf.cpf = " +documento+" AND u.senha= "+senha+";" ;
                    int rowsAffected = db.Database.ExecuteSqlCommand(query);

                }
                else if (documento.Length == 18 || documento.Length == 14) {
                    query += "JOIN pessoas_juridicas AS pj ON pj.fk_pj_user=u.id AND pj.cnpj = " +documento+ "AND u.senha= "+senha+";";
                    int rowsAffected = db.Database.ExecuteSqlCommand(query);
                }
                else
                {
                    MessageBox.Show("Informações inválidas!");
                }

            }
            MessageBox.Show("login realizado com suscesso!");
            frmHome frm = new frmHome();
            this.Hide();
            frm.Show();

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
