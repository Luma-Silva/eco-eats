﻿using System;
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
    public partial class frmAlterarSenha : Form
    {
    
        public frmAlterarSenha(bool isLogin)
        {
      
            InitializeComponent();
            if (isLogin)
            {
                btnVoltar.Visible = true;
            }
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
            string email = txtEmail.Text;

           

            string confirmasenha = lblConfirm.Text;

           
            if(senha1 ==""|| senha2 =="" || email == "" )
            {
                if(senha1 == "")
                {
                    txtNsenha.BackColor = Color.Red;
                }
                else
                {
                    txtNsenha.BackColor = Color.White;
                }
                if (senha2 == "")
                {
                    txtRsenha.BackColor = Color.Red;
                }
                else
                {
                    txtRsenha.BackColor = Color.White;
                }
                if (email == "")
                {
                    txtEmail.BackColor = Color.Red;
                }
                else
                {
                    txtEmail.BackColor = Color.White;
                }
                MessageBox.Show("Preencha todos os campos!");
            }
            else {
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
                    MessageBox.Show("Senha Redefinida :)");
                }
                else
                {
                    MessageBox.Show("As senhas não conferem");
                }
              
            }
            using (MyDbContext db = new MyDbContext())
            {

                string query = "SELECT * FROM users;";

               // Usuarios user = db.Database.SqlQuery<Usuarios>(query).Single();



                //string query = "UPDATE ecoeats.usuarios SET email='', senha= '' WHERE id= '' ;";


                //  string query = @"UPDATE ecoeats.usuarios SET email= "@email", senha= "@senha" WHERE id="@id" ; ";

                //  var parameters = new[]


                //   new MySqlParameter("@email", email)

                //  new MySqlParameter("@senha", novasenha)


                int rowsAffected = db.Database.ExecuteSqlCommand(query);


            }


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

       


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }
    }
}
