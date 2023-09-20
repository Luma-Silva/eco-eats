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
using ecoEats.Models;

namespace ecoEats
{
    public partial class frmHome : Form
    {
        int userid;
        bool cnpj;
        public frmHome(int userid,bool cnpj)
        {
            this.userid= userid;
            this.cnpj= cnpj;                                    
            InitializeComponent();
            if (this.cnpj == false)
            {
                comprarSelo.Enabled = false;
            }
        }
        private Form frmAtivo;
      

       
        private void FechaForm()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        private void MostraForm(Form frm) {
            FechaForm();
            frmAtivo= frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Size = panelPrincipal.Size;
            this.Text= frm.Text;
            frm.Show();
        
        }

        private void CadastroNome_Click(object sender, EventArgs e)
        {
            MostraForm(new frmPorNome(this.userid, this)); 


        }

        private void CadastroCodigo_Click(object sender, EventArgs e)
        {
            MostraForm (new frmCodigoBarras(this,this.cnpj));



        }

        private void alterarSenha_Click(object sender, EventArgs e)
        {
            MostraForm(new frmAlterarInfo(false));
        }

        private void comprarSelo_Click(object sender, EventArgs e)
        {
            MostraForm(new frmPagamento(2));
        }

        private void Sair_Click(object sender, EventArgs e)
        { 
           frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

           
            using (MyDbContext db = new MyDbContext())
            {
                MessageBox.Show(this.userid.ToString());
                string query;
                query = "SELECT nome FROM usuarios AS u WHERE u.id =" + this.userid + " LIMIT 1;";

                string username = db.Database.SqlQuery<string>(query).SingleOrDefault();
                menuUser.Text="Olá!, "+username;



                }
            }

        private void produtos_Click(object sender, EventArgs e)
        {
            MostraForm(new ConsultaProdutos(this.userid, this));
        }


        public void mostraFormExterno(Form frm)
        {
            MostraForm(frm);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
    }
}
