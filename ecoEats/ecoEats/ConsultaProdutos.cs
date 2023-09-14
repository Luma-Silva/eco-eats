using ecoEats.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ecoEats
{
    public partial class ConsultaProdutos : Form
    {
        int userid;
        private List<Produto> productList;

        public ConsultaProdutos(int userid)
        {
            InitializeComponent();
           
            CreateProductCards(); // Chame a função para criar os cards de produto.
            this.userid = userid;
        }


        



        private void InitializeProductList()
        {
            using (MyDbContext db = new MyDbContext())
            {

                string query = @"SELECT p.id, p.codigo_barras, p.nome, p.data_validade, p.fabricacao, p.valor_produto, p.descricao, p.lote, p.categoria_produto, p.score
                                    FROM produtos AS p  JOIN cliente_produto AS cp ON p.id = cp.fk_cp_prod JOIN usuarios AS u  ON cp.fk_cp_user = u.id  WHERE u.id = @id;";

                var parameters = new[]
                {

                        new MySqlParameter("@id", this.userid),



                    };

                List<Produto> produtos = db.Database.SqlQuery<Produto>(query, parameters).ToList();
                
                this.productList = produtos;

            } 

    
        }


        private void CreateProductCards()
        {
            InitializeProductList(); // Chame a função para inicializar sua lista de produtos (você deve implementar isso).
            // Limpe qualquer controle anterior no formulário.
            Controls.Clear();

            // Loop através da lista de produtos e crie um GroupBox para cada um.
            for (int i = 0; i < this.productList.Count; i++)
            {
                MessageBox.Show("teste");
                System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

                groupBox.Text = this.productList[i].nome;
                groupBox.Location = new System.Drawing.Point(10, 10 + i * 80); // Posicione os GroupBoxes verticalmente.


                Label nomeLabel = new Label();
                nomeLabel.Text = "Nome: " + this.productList[i].nome;
                nomeLabel.Location = new System.Drawing.Point(10, 20);

                Label codigoLabel = new Label();
                codigoLabel.Text = "Codigo: " + this.productList[i].codigo_barras;
                codigoLabel.Location = new System.Drawing.Point(10, 40);

                // Adicione outros rótulos conforme necessário.

                // Adicione os rótulos ao GroupBox.
                groupBox.Controls.Add(nomeLabel);
                groupBox.Controls.Add(codigoLabel);

                // Adicione o GroupBox ao formulário.
                Controls.Add(groupBox);
            }
        }





        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {

            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Source Code Pro Semibold", 10, FontStyle.Regular);




            // Calcula a posição para centralizar o formulário na tela
           int x = (Screen.PrimaryScreen.WorkingArea.Width - gb.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - gb.Height) / 2;

            // Ajusta a posição do formulário
            gb.Location = new Point(x, y);


            gb.BackColor = this.BackColor;
           
        }

    }
}
