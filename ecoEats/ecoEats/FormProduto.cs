using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ecoEats.Models;

namespace ecoEats
{
    public partial class FormProduto : Form
    {
        public FormProduto(string cod)
       {
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())

            {


                string query = "SELECT * FROM produtos WHERE codigo_barras = '" + cod + "';";
                MessageBox.Show(query);
             
                List<Produto> produto = db.Database.SqlQuery<Produto>(query).ToList();

                dataGProduto.DataSource = produto;


            }
        }


       // using (MyDbContext db = new MyDbContext())
   //     {
       // string query = "SELECT * FROM ";
    //    list <Produto> produtos = DBConcurrencyException.database.SqlQuery<Produto>(query).ToList 










        private void FormProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
