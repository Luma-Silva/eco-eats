using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;

using MySql.Data.MySqlClient;
using ecoEats;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Windows.Markup;
using ecoEats.Models;
using ecoEats.Properties;

namespace ecoEats
{
    public partial class frmPagamento : Form
    {
        int valor;
        int userId;
        bool cnpj;
        frmHome pai;
        public frmPagamento(int userId, int valor, bool cnpj, frmHome pai)
        {
            InitializeComponent();
            this.valor = valor;
            this.userId = userId;
            this.cnpj = cnpj;
            this.pai = pai;
        }
        private void btnConfirmarPagamento_Click(object sender, EventArgs e)

        {
            string Tipodopagamento = "";
            if (ckbCredito.Checked)
            {
                Tipodopagamento = "Crédito";
            }
            else
            {
                Tipodopagamento = "Débito";
            }
            string CPF = mtbCpf.Text;

            string NomeNoCartão = txtNomeNoCartao.Text;

            string NumeroDoCartão = mtbCartao.Text;

            string codigo = txtCodigo.Text;

            string dataDeValidade = dtpDataDeValidade.Value.ToString("MM-yy");
            if (CPF == "" || NomeNoCartão == "" || NumeroDoCartão == "" || codigo == "" || dataDeValidade == "")
            {

                if (CPF == "")
                {
                    mtbCpf.BackColor = Color.Red;
                }
                else
                {
                    mtbCpf.BackColor = Color.White;
                }

                if (NomeNoCartão == "")
                {
                    txtNomeNoCartao.BackColor = Color.Red;
                }
                else
                {
                    txtNomeNoCartao.BackColor = Color.White;
                }
                if (codigo == "")
                {
                    txtCodigo.BackColor = Color.Red;
                }
                else
                {
                    txtCodigo.BackColor = Color.White;
                }

                if (NumeroDoCartão == "")
                {
                    mtbCartao.BackColor = Color.Red;
                }
                else
                {
                    mtbCartao.BackColor = Color.White;
                }


                MessageBox.Show("Preencha todos os campos!");

            }



            else if (ckbDebito.Checked == true && ckbCredito.Checked == true)
            {
                MessageBox.Show("Selecione SOMENTE UMA forma de pagamento!!");
            }
            else if (ckbDebito.Checked == false && ckbCredito.Checked == false)
            {
                MessageBox.Show("Selecione a forma de pagamento!!");
            }
            else
            {
                if (ckbDebito.Checked == true || ckbCredito.Checked == true)
                {
                    using (MyDbContext db = new MyDbContext())
                    {
               
                        string query = "SELECT * FROM pessoas_juridicas WHERE fk_pj_user =" + this.userId + " LIMIT 1;";
                        Juridica cnpj = db.Database.SqlQuery<Juridica>(query).SingleOrDefault();

             
                        
                        query = "INSERT INTO pagamentos (forma_pagamento, cpf_titular, cvv, nome_cartao, numero_cartao, fk_pag_pj, valor) " +
                            "VALUES (@forma_pagamento, @cpf, @cvv, @nome_cartao, @numero_cartao, @fk, @valor);";

                        var parameters = new[]
                        {
                            new MySqlParameter("@forma_pagamento", Tipodopagamento ),
                            new MySqlParameter("@cpf",CPF),
                            new MySqlParameter("@cvv",codigo),
                            new MySqlParameter("@nome_cartao",NomeNoCartão),
                            new MySqlParameter("@numero_cartao",NumeroDoCartão),
                            new MySqlParameter("@fk", cnpj.Id),
                            new MySqlParameter("@valor", this.valor)
                        };
                        int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);
                    }
                    MessageBox.Show("Pagamento concluído!");
                  
                    ConsultaProdutos frm = new ConsultaProdutos(this.userId,this.pai,this.cnpj);
                    this.pai.mostraFormExterno(frm);
                  
                }
            }
        }
        private void frmPagamento_Load(object sender, EventArgs e)
        {
           // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;

            // Ajusta a posição do formulário
            groupBox1.Location = new Point(x, y);

            if(this.valor == 500)
            {
                picSelo.BackgroundImage = Resources.selo0;
                lblValorSelo.Text = this.valor.ToString();
            }
            else if (this.valor == 1000)
            {
                picSelo.BackgroundImage = Resources.selo50;
                lblValorSelo.Text = this.valor.ToString();
            }
            else if (this.valor == 1200)
            {
                picSelo.BackgroundImage = Resources.selo100;
                lblValorSelo.Text = this.valor.ToString();
            }
        }
        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;
            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }  
}

