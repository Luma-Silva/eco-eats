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
using System.Runtime.CompilerServices;
using ecoEats.Properties;

namespace ecoEats
{
    public partial class frmCodigoBarras : Form
    {
      
        frmHome pai;
        bool cnpj;
        int userid;
        public frmCodigoBarras(frmHome pai, bool cnpj, int userid)
        {
            InitializeComponent();
            this.pai = pai;
            this.cnpj = cnpj;
            this.userid = userid;
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {         
            string cod = textBoxDigCod.Text;

            if (cod == "")
            {
                MessageBox.Show("Digite algum código de barras");
                return;
            }
            else
            {
                using (MyDbContext db = new MyDbContext())

                {


                    string query = "SELECT id FROM produtos WHERE codigo_barras = '" + cod + "' LIMIT 1;";
           

                    int idProduto = db.Database.SqlQuery<int>(query).SingleOrDefault();
                

                    frmProduto frm = new frmProduto(idProduto,this.pai,this.cnpj, this.userid);
                    this.pai.mostraFormExterno(frm);






                }
            }

           
             


            

            
        
             
        }


        private void frmCodigoBarras_Load_1(object sender, EventArgs e)
        {
            Font fontePadrao = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            AplicarFonteControles(this, fontePadrao);
            int x = (Screen.PrimaryScreen.WorkingArea.Width - groupBox1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);

        }
        private void AplicarFonteControles(Control control, Font fonte)
        {
            control.Font = fonte;
            foreach (Control filho in control.Controls)
            {
                AplicarFonteControles(filho, fonte);
            }
        }

    }
}
