using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ecoEats
{
    public partial class frmPorNome : Form
    {
        public frmPorNome()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
           Font fontePadrao = new Font("Source Code Pro Semibold", 10 ,FontStyle.Regular); 
            // Percorre todos os controles do formulário e aplica a fonte padrão
            AplicarFonteControles(this, fontePadrao);
            // Verifica se o formulário está maximizado
            
            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;

            // Ajusta a posição do formulário
            groupBox1.Location = new Point(x, y);


            groupBox1.BackColor = this.BackColor;


        }

        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;

            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }
      



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            //esse if serve para verificar se o txt esta vazio se estiver ele vai aparecer a massage box 
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {

                MessageBox.Show("O Nome do Produto é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.Red;
                return;
                // o return sai do erro e segue o programa 



            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {

                MessageBox.Show("O Codigo do Produto é  obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.BackColor = Color.Red;
                return;
            }
           
                        //estou declarando as variaveis para elas ficarem salvas no Botão salvar
                string Validade = DTPValidade.Value.ToString("yyyy-MM-dd");
            string Fabricacao = DTPFabricacao.Value.ToString("yyyy-MM-dd");
            string codigo = txtCodigo.Text;
            string Lote = txtLote.Text;
            string Nome = txtNome.Text;
            string Valor = txtValor.Text;
            string categoria = CBCategoria.SelectedItem.ToString();
            string descricao = txtDescricao.Text;
            string score = lblscore.Text;
            //na proxima linha eu fiz uma variavel para aparecer esta mensagem no mensagem boox.show
            // $ este simbolo de cifrão serve para concatenar a mensagem igual ao simbolo de +
            string mensagem = $"Código de Barras: {codigo}\n" +

                              $"Nome do Produto: {Nome}\n" +

                              $"Valor: {Valor:C}\n" +

                              $"Categoria do Produto:{categoria}" +

                              $"Descrição do Produto:{descricao}\n" +

                              $"Data de Validade: {Validade}\n" +

                              $"Data de Fabricação: {Fabricacao}\n" +

                              $"Lote: {Lote}\n" +

                              $"Score:{score}\n";

            //Ao inves do menssage box, jogar para o banco de dados (depois)
            // este MessageBoxButtons serve para eu criar uma caixa com o ok ou cancel

            // o messageBoxIcon serve para eu colocar o simbolo de informação na message show
            MessageBox.Show(mensagem, "Informações do Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
















            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO ecoeats.produtos(codigo_barras, nome, data_validade, fabricacao, valor_produto, descricao, lote, categoria_produto, score) 
                              VALUES (@codigo_barras, @nome, @data_validade, @fabricacao, @valor_produto, @descricao, @lote, @categoria_produto, @score); SELECT LAST_INSERT_ID();";
                var parameters = new[]
                {

                    new MySqlParameter("@codigo_barras",codigo),
                    
                    new MySqlParameter("@nome",Nome),

                    new MySqlParameter("@data_validade",Validade),
                    new MySqlParameter("@fabricacao" ,Fabricacao),
                    new MySqlParameter("@valor_produto",Valor),
                    new MySqlParameter("@descricao", descricao),
                    new MySqlParameter("@lote",Lote),
                    new MySqlParameter("@categoria_produto",categoria),
                    new MySqlParameter("@score",score),
                   

                };



                int produtoId = db.Database.SqlQuery<int>(query, parameters).Single();

            }


        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {

            //o empty significa vazio e o noww volta para data de hoje

            txtCodigo.Text = string.Empty;
            txtLote.Text = string.Empty;
            txtNome.Text = string.Empty;
            CBCategoria.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
            DTPValidade.Value = DateTime.Now;
            DTPFabricacao.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
