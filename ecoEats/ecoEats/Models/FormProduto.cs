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

namespace ecoEats.Models
{
    public partial class FormProduto : Form
    {
   //     public FormProduto()
       // {
          //  InitializeComponent();
       // }


       // using (MyDbContext db = new MyDbContext())
   //     {
       // string query = "SELECT * FROM ";
    //    list <Produto> produtos = DBConcurrencyException.database.SqlQuery<Produto>(query).ToList 










        private void FormProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM ecoeats.produtos;";

               // List<FormProduto> produto = db.Database.SqlQuery<Produto>(query).ToList (0);

                //dGVProduto.DataSource = produto;


            }
        }
    }
}
