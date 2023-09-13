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
        public ConsultaProdutos(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            using (MyDbContext db = new MyDbContext())

            {

                string query = @"SELECT p.id, p.codigo_barras, p.nome, p.data_validade, p.fabricacao, p.valor_produto, p.descricao, p.lote, p.categoria_produto, p.score
                                FROM produtos AS p  JOIN cliente_produto AS cp ON p.id = cp.fk_cp_prod JOIN usuarios AS u  ON cp.fk_cp_user = u.id  WHERE u.id = @id;";

                var parameters = new[]
                {

                    new MySqlParameter("@id", this.userid),



                };

                List<Produto> produtos = db.Database.SqlQuery<Produto>(query, parameters).ToList();
                dgvlista.DataSource = produtos;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {

            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Source Code Pro Semibold", 10, FontStyle.Regular);




            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - dgvlista.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - dgvlista.Height) / 2;

            // Ajusta a posição do formulário
            dgvlista.Location = new Point(x, y);


            dgvlista.BackColor = this.BackColor;












        }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
             public class Product
        {
            public string Name { get; set; }
            public decimal Codigo { get; set; }
        }

        private List<Product> productList;

        private void InitializeProductList()
        {
            // Aqui, você deve inicializar sua lista de produtos.
            // Por exemplo:
            productList = new List<Product>
        {
            new Product { Name = "Produto 1", Codigo = 10.99M },
            new Product { Name = "Produto 2", Codigo = 20.49M },
            new Product { Name = "Produto 3",  Codigo= 5.99M }
            // Adicione mais produtos conforme necessário.
        };
        }

        private void CreateProductCards()
        {
            // Limpe qualquer controle anterior no formulário.
            Controls.Clear();

            // Loop através da lista de produtos e crie um GroupBox para cada um.
            for (int i = 0; i < productList.Count; i++)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = productList[i].Name;
                groupBox.Location = new System.Drawing.Point(10, 10 + i * 80); // Posicione os GroupBoxes verticalmente.

                Label nameLabel = new Label();
                nameLabel.Text = "Nome: " + productList[i].Name;
                nameLabel.Location = new System.Drawing.Point(10, 20);

                Label codigoLabel = new Label();
                codigoLabel.Text = "Codigo de Barras: " + productList[i].Codigo.ToString("");
                codigoLabel.Location = new System.Drawing.Point(10, 40);

                // Adicione outros rótulos conforme necessário.

                // Adicione os rótulos ao GroupBox.
                groupBox.Controls.Add(nameLabel);
                groupBox.Controls.Add(codigoLabel);

                // Adicione o GroupBox ao formulário.
                Controls.Add(groupBox);
            }
        }


    }

}
