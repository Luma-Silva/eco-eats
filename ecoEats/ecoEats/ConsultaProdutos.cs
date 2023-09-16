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
        frmHome pai;
        string edit_prod;
        private List<Produto> productList;
        string nome;

        public ConsultaProdutos(int userid, frmHome pai)
        {
            InitializeComponent();

            this.userid = userid;
            this.pai = pai;
            CreateProductCards();
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

            int groupBoxWidth = 250; // Largura de cada GroupBox
            int groupBoxHeight = 100; // Altura de cada GroupBox
            int groupBoxSpacing = 10; // Espaçamento entre os GroupBoxes

            int maxGroupBoxesPerRow = 5; // Número máximo de GroupBoxes por linha
            int currentRow = 0; // Contador de linhas
            int currentColumn = 0; // Contador de colunas

            // Loop através da lista de produtos e crie um GroupBox para cada um.
            for (int i = 0; i < this.productList.Count; i++)
            {

                System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

               // groupBox.Text = "Produto";
                groupBox.Width = groupBoxWidth;
                groupBox.Height = groupBoxHeight;
                groupBox.Location = new System.Drawing.Point(
                    10 + currentColumn * (groupBoxWidth + groupBoxSpacing), // Posição horizontal
                    10 + currentRow * (groupBoxHeight + groupBoxSpacing) // Posição vertical
                );

                groupBox.Click += GroupBox_Click;

                Label nomeLabel = new Label();
                nomeLabel.Text = "Nome: " + this.productList[i].nome;
                nomeLabel.Location = new System.Drawing.Point(10, 30);
                

                Label codigoLabel = new Label();
                string cod = this.productList[i].codigo_barras.ToString();
                codigoLabel.AutoSize = true;
                codigoLabel.Text = "Codigo de barras: " + cod;
                codigoLabel.Location = new System.Drawing.Point(10, 60);

                groupBox.Tag = this.productList[i].Id;

                

                // Adicione os rótulos ao GroupBox.
                groupBox.Controls.Add(nomeLabel);
                groupBox.Controls.Add(codigoLabel);

                // Adicione o GroupBox ao formulário.
                Controls.Add(groupBox);
                // Atualize os contadores de linha e coluna
                currentColumn++;


                if (currentColumn >= maxGroupBoxesPerRow)

                {
                    currentColumn = 0;
                    currentRow++;
                }
            }
        }


        private System.Windows.Forms.GroupBox selectedGroupBox = null;


        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {
            CreateProductCards();
        }
        private void GroupBox_Click(object sender, EventArgs e)
        {
            Font fontePadrao = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            
            if (sender is System.Windows.Forms.GroupBox clickedGroupBox)
            {
                // Desmarque o GroupBox anteriormente selecionado (se houver)
                if (selectedGroupBox != null)
                {
                    // Redefina a aparência do GroupBox desmarcado aqui
                    selectedGroupBox.BackColor = SystemColors.Control;
                }

                // Marque o GroupBox clicado
                clickedGroupBox.BackColor = Color.LightBlue;

                // Atualize a variável de controle
                selectedGroupBox = clickedGroupBox;

                this.edit_prod = clickedGroupBox.Tag.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Suponha que você tenha o ID do produto a ser editado.
            int idDoProdutoAEditar = Convert.ToInt32(this.edit_prod); // Substitua pelo ID real do produto.

            // Crie uma instância do formulário frmPorNome, passando o ID do produto.
            frmPorNome formularioEdicao = new frmPorNome(this.userid, this.pai, idDoProdutoAEditar);

            // Exiba o formulário de edição.
            this.pai.mostraFormExterno(formularioEdicao);
        }
    }
}

