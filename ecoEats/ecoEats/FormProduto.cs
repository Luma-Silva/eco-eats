using ecoEats.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;
using ecoEats.Models;



namespace ecoEats
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();

            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM produtos;";

                List<Produto> produtos = db.Database.SqlQuery<Produto>(query).ToList();

                dgvProduto.DataSource = produtos;

            }



            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM impactos_ambientais;";

                List<ImpactoAmbientais> impactos_ambientais = db.Database.SqlQuery<ImpactoAmbientais>(query).ToList();

                dgvProduto.DataSource = impactos_ambientais;


            }



            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM p_alternativos;";

                List<Palternativos> p_alternativos = db.Database.SqlQuery<Palternativos>(query).ToList();

                dgvProduto.DataSource = p_alternativos;


            }




            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM valores_nutricionais;";

                List<ValoresNutricionais> valores_nutricionais = db.Database.SqlQuery<ValoresNutricionais>(query).ToList();

                dgvProduto.DataSource = valores_nutricionais;

            }








        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
