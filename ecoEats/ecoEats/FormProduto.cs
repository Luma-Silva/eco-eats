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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            Font fontePadrao = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
           
            int x = (Screen.PrimaryScreen.WorkingArea.Width - dataGProduto.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - dataGProduto.Height) / 2;
            dataGProduto.Location = new Point(x, y);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
