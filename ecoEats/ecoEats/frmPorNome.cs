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

using MySqlX.XDevAPI.Common;
using ecoEats.Models;

namespace ecoEats
{
    public partial class frmPorNome : Form
    {
        int userid;
        frmHome pai;

        public frmPorNome(int userid, frmHome pai)
        {
            InitializeComponent();
            this.userid = userid;
            this.pai = pai; 
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








            
            string mensagem = $"Código de Barras: {codigo}\n" +
                              $"Nome do Produto: {Nome}\n" +
                              $"Valor: {Valor:C}\n" +
                              $"Categoria do Produto: {categoria}\n" + // Certifique-se de adicionar \n para separar linhas
                              $"Descrição do Produto: {descricao}\n" +
                              $"Data de Validade: {Validade}\n" +
                              $"Data de Fabricação: {Fabricacao}\n" +
                              $"Lote: {Lote}\n";

            // Exibe o MessageBox com a variável 'mensagem' definida acima
            DialogResult result = MessageBox.Show(mensagem, "Informações do Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {

                

               
            }
            else if (result == DialogResult.Cancel)
            {
                // Código para lidar com o cancelamento
                return;
            }











            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO ecoeats.produtos(codigo_barras, nome, data_validade, fabricacao, valor_produto, descricao, lote, categoria_produto) 
                              VALUES (@codigo_barras, @nome, @data_validade, @fabricacao, @valor_produto, @descricao, @lote, @categoria_produto);SELECT LAST_INSERT_ID();";
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



                };


                //cadastra o produto e pegar o ultimo id 
                int idProduto = db.Database.SqlQuery<int>(query, parameters).SingleOrDefault();

                //inserir na tabela cliente produto 







                string query1 = @"SELECT * FROM usuarios WHERE id = @id LIMIT 1;";


                var parameters1 = new[] {
                new MySqlParameter("@id", this.userid)
                };

                Usuario usuario = db.Database.SqlQuery<Usuario>(query1, parameters1).SingleOrDefault();

                if (usuario == null)
                {
                    MessageBox.Show("Não encontrou");
                    return;
                }



              

                if (usuario == null)
                {
                    MessageBox.Show("Usuario não encontrado");
                    return;
                }



                string query2 = @"SELECT * FROM produtos WHERE id = @id LIMIT 1;";

                var parameters2 = new[]
                {

                    new MySqlParameter("@id",idProduto )

 

                };



                Produto produto = db.Database.SqlQuery<Produto>(query2, parameters2).SingleOrDefault();

                if(produto == null)
                {
                    MessageBox.Show("Produto não encontrado");
                    return;
                }




                query = @"INSERT INTO cliente_produto(fk_cp_prod, fk_cp_user) 
                              VALUES (@id_prod, @id_user);";

                parameters = new[]
                {

                    new MySqlParameter("@id_prod",produto.Id),
                    new MySqlParameter("@id_user",usuario.Id)



                };

                db.Database.ExecuteSqlCommand(query, parameters);

                MessageBox.Show("Salvo com sucesso!");

                this.pai.mostraFormExterno(new ConsultaProdutos(this.userid));


            }






        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {

            //o empty significa vazio e o noww volta para data de hoje

            txtCodigo.Text = string.Empty;
            
            txtNome.BackColor = Color.White;
            txtCodigo.BackColor = Color.White;
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

        private void frmPorNome_Load(object sender, EventArgs e)
        {

        }
    }
}
