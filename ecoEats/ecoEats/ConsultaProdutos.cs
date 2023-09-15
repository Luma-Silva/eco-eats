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



        private List<Produto> productList;

        public ConsultaProdutos(int userid, frmHome pai)
        {
            InitializeComponent();

            CreateProductCards(); // Chame a função para criar os cards de produto.
            this.userid = userid;
            this.pai = pai;
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




            int groupBoxWidth = 300; // Largura de cada GroupBox
            int groupBoxHeight = 100; // Altura de cada GroupBox
            int groupBoxSpacing = 10; // Espaçamento entre os GroupBoxes

            int maxGroupBoxesPerRow = 5; // Número máximo de GroupBoxes por linha
            int currentRow = 0; // Contador de linhas
            int currentColumn = 0; // Contador de colunas

            // Loop através da lista de produtos e crie um GroupBox para cada um.
            for (int i = 0; i < this.productList.Count; i++)
            {

                System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

                groupBox.Text = "Seus Produtos";
                groupBox.Width = groupBoxWidth;
                groupBox.Height = groupBoxHeight;
                groupBox.Location = new System.Drawing.Point(
                    10 + currentColumn * (groupBoxWidth + groupBoxSpacing), // Posição horizontal
                    10 + currentRow * (groupBoxHeight + groupBoxSpacing) // Posição vertical
                );

                // Adicione um manipulador de evento de clique a cada GroupBox
                groupBox.Click += GroupBox_Click;



               

                Label nomeLabel = new Label();
                nomeLabel.Text = "Nome: " + this.productList[i].nome;
                nomeLabel.Location = new System.Drawing.Point(10, 30);
               
                Label codigoLabel = new Label();
                string cod = this.productList[i].codigo_barras.ToString();
                codigoLabel.Text = "Codigo de Barras: " + cod;
                codigoLabel.Location = new System.Drawing.Point(10, 60);

                // Adicione outros rótulos conforme necessário.

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


            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Source Code Pro Semibold", 10, FontStyle.Regular);




            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - gb.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - gb.Height) / 2;

            // Ajusta a posição do formulário
            gb.Location = new Point(x, y);


            gb.BackColor = this.BackColor;

        }
        private void GroupBox_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {




            // Suponha que você tenha o ID do produto a ser editado.
            int idDoProdutoAEditar = 123; // Substitua pelo ID real do produto.

            // Crie uma instância do formulário frmPorNome, passando o ID do produto.
          frmPorNome formularioEdicao = new frmPorNome(this.userid, this.pai, idDoProdutoAEditar);

            // Exiba o formulário de edição.
          formularioEdicao.Show();

















        }
    }
}

