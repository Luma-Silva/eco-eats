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

namespace ecoEats
{
    public partial class frmPagamento : Form
    {
        int userId;
        public frmPagamento(int userId)
        {
            this.userId = userId;
            InitializeComponent();
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
            string CPF = txtCpf.Text;

            string NomeNoCartão = txtNomeNoCartao.Text;

            string NumeroDoCartão = txtNumeroDoCartao.Text;

            string codigo = txtCodigo.Text;

            string dataDeValidade = dtpDataDeValidade.Value.ToString("MM-yy");
            if (CPF == "" || NomeNoCartão == "" || NumeroDoCartão == "" || codigo == "" || dataDeValidade == "")
            {

                if (CPF == "")
                {
                    txtCpf.BackColor = Color.Red;
                }
                else
                {
                    txtCpf.BackColor = Color.White;
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
                    txtNumeroDoCartao.BackColor = Color.Red;
                }
                else
                {
                    txtNumeroDoCartao.BackColor = Color.White;
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
                    MessageBox.Show("CPF:" + CPF + "\n" +
              "Nome No Cartão:" + NomeNoCartão + "\n" +
              "Número Do Cartão:" + NumeroDoCartão + "\n" +
              "Código:" + codigo + "\n" +
              "Data De Validade:" + dataDeValidade + "\n" +
              "Forma de pagamento:" + Tipodopagamento);

                }

            }


            using (MyDbContext db = new MyDbContext())
            {
                string query = "INSERT INTO pagamentos (forma_pagamento, cpf_titular, cvv, nome_cartao, numero_cartao, fk_pag_pj) " +
                    "VALUES (@forma_pagamento, @cpf, @cvv, @nome_cartao, @numero_cartao, @fk);";

                var parameters = new[]
                {
                    new MySqlParameter("@forma_pagamento", Tipodopagamento ),
                    new MySqlParameter("@cpf",CPF),
                    new MySqlParameter("@cvv",codigo),
                    new MySqlParameter("@nome_cartao",NomeNoCartão),
                    new MySqlParameter("@numero_cartao",NumeroDoCartão),
                    new MySqlParameter("@fk", this.userId)
                };

                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);
            }

        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Arial", 14, FontStyle.Regular);



            // Percorre todos os controles do formulário e aplica a fonte padrão
            AplicarFonteControles(this, fontePadrao);
            // Verifica se o formulário está maximizado

            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;



            // Ajusta a posição do formulário
            groupBox1.Location = new Point(x, y);
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

