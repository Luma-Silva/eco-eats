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
        public frmHome(int userid)
        {
            this.userid= userid;
            InitializeComponent();
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
            MostraForm(new frmPorNome());
        }

        private void CadastroCodigo_Click(object sender, EventArgs e)
        {
            MostraForm (new frmCodigoBarras());



        }

        private void alterarSenha_Click(object sender, EventArgs e)
        {
            MostraForm(new frmAlterarInfo(false));
        }

        private void comprarSelo_Click(object sender, EventArgs e)
        {
            MostraForm(new frmPagamento());
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

                string query;
                query = "SELECT u.nome FROM usuarios AS u WHERE u.id =" + this.userid + ";";
                string username = db.Database.SqlQuery<string>(query).Single();
                menuUser.Text="Olá!,"+username;



                }
            }
    }
}
