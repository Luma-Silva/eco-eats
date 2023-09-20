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
using ecoEats.Models;

using System.Data.Entity.ModelConfiguration.Conventions;

using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Data.Entity.Infrastructure;

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
          
           frmAlterarInfo frm = new frmAlterarInfo(true);
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

                    string query;

                    query = "SELECT u.id FROM usuarios AS u WHERE u.email ='" + documento + "'  AND u.senha ='" + senha + "' LIMIT 1; ";

                    int IdUser = db.Database.SqlQuery<int>(query).SingleOrDefault();

                    query = "SELECT 1 FROM usuarios AS u JOIN pessoas_juridicas AS pj ON pj.fk_pj_user="+IdUser+" LIMIT 1;";
                   
                    int existe = db.Database.SqlQuery<int>(query).SingleOrDefault();
                    MessageBox.Show(existe.ToString());
                if (existe == 0)
                    {
                        
                        MessageBox.Show("Login realizado com suscesso!");
                        frmHome frm = new frmHome(IdUser, false);
                        this.Hide();
                        frm.Show();
                    } else if(existe == 1) {
                         MessageBox.Show("Login realizado com suscesso!");
                        frmHome frm = new frmHome(IdUser, true);
                        this.Hide();
                        frm.Show();
                    }




                
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

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void txtCPF_CNPJ_TextChanged(object sender, EventArgs e)
        {
            string email =txtCPF_CNPJ.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido!");
               txtCPF_CNPJ.BackColor = Color.PaleVioletRed;
            }
        }
    }
}
