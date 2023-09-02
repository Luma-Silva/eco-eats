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








            using (MyDbContext db = new MyDbContext())

            {

                string query = @"SELECT p.id, p.codigo_barras, p.nome, p.data_validade, p.fabricacao, p.valor_produto, p.descricao, p.lote, p.categoria_produto, p.score
                                FROM produtos AS p  JOIN cliente_produto AS cp ON p.id = cp.fk_cp_prod JOIN usuarios AS u  ON cp.fk_cp_user = u.id  WHERE p.id = @id;";

                var parameters = new[]
                {

                    new MySqlParameter("@id", this.userid),

                   

                };

                List<Produto> produtos = db.Database.SqlQuery<Produto>(query, parameters).ToList();
                dgvlista.DataSource = produtos;


            }



        }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
    }
}
