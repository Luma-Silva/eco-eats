﻿using ecoEats.Properties;
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
using ecoEats.Models;

namespace ecoEats
{
    public partial class frmCadastroCPF : Form
    {
        public frmCadastroCPF()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text;
            string nome = txtNome.Text;
            string sexo = cmbBxSexo.Text;
            string nascimento = dpNascimento.Value.ToString("yyyy-MM-dd");
            DateTime today = DateTime.Now;
            DateTime dataNascimento = dpNascimento.Value;
            int age = (int)((today - dataNascimento).TotalDays / 365.25);
            string uf = txtUf.Text;
            string naturalidade = txtNaturalidade.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mskCep.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;
            string cidade = txtCidade.Text;
            string senha = txtSenha.Text;
            string confirmarsenha = txtCSenha.Text;


            if
                (cpf == "" || nome == "" || sexo == "" || nascimento == "" || uf == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "" || rdBtnConfirmar.Checked == false)
            {
                if (cpf == "")
                {
                    mskCpf.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    mskCpf.BackColor = Color.White;
                }
                if (nome == "")
                {
                    txtNome.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtNome.BackColor = Color.White;
                }
                if (sexo == "")
                {
                    cmbBxSexo.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    cmbBxSexo.BackColor = Color.White;
                }
                if (nascimento == "")
                {
                    dpNascimento.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    dpNascimento.BackColor = Color.White;
                }
                if (uf == "")
                {
                    txtUf.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    txtUf.BackColor = Color.White;
                }
                if (telefone == "")
                {
                    mskTelefone.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    mskTelefone.BackColor = Color.White;
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
                if (rdBtnConfirmar.Checked != true)
                {
                    MessageBox.Show("Confirme a veracidade dos dados");
                }

                MessageBox.Show("Preencha todos os campos");

            }
            else if (senha != confirmarsenha)
            {

                MessageBox.Show("Senhas diferentes!");
                txtCSenha.BackColor = Color.PaleVioletRed;
                txtSenha.BackColor = Color.PaleVioletRed;
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


                    query = "INSERT INTO pessoas_fisicas (cpf, data_nascimento, sexo, fk_pf_user) VALUES ('" + cpf + "', '" + nascimento + "', '" + sexo + "', " + newUserId + ");";

                    db.Database.ExecuteSqlCommand(query);


                    query = @"INSERT INTO enderecos (rua, numero, cep, cidade, bairro, naturalidade, uf, fk_end_user) VALUES ('" + endereco + "', '" + numero + "', '" + cep + "', '" + cidade + "', '" + bairro + "', '" + naturalidade + "','" + uf + "', " + newUserId + ");";

                    db.Database.ExecuteSqlCommand(query);
                    MessageBox.Show("Cadastro concluído!");
                    frmLogin frm = new frmLogin();
                    this.Hide();
                    frm.Show();
                }

            }

        }

        private void cmbBxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sexo = cmbBxSexo.SelectedItem.ToString();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido!");
            }
        }

        private void pbSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                pbSenha.Image = Resources.view;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pbSenha.Image = Resources.hide;
                txtSenha.UseSystemPasswordChar = false;
            }

        }

        private void pbConfirmarSenha_Click(object sender, EventArgs e)
        {

            if (txtCSenha.PasswordChar == '*')
            {
                txtCSenha.PasswordChar = '\0';
                pbConfirmarSenha.Image = Resources.view;
                txtCSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtCSenha.PasswordChar = '*';
                pbConfirmarSenha.Image = Resources.hide;
                txtCSenha.UseSystemPasswordChar = false;
            }
        }

        private void frmCadastroCPF_Load_1(object sender, EventArgs e)
        {
            Font fontePadrao = new Font("Microsoft Tai Le", 14, FontStyle.Bold);

            AplicarFonteControles(this, fontePadrao);

            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;

            groupBox1.Location = new Point(x, y);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;

            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }

        
    }
}