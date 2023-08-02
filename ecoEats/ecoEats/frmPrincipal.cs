using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecoEats
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cnpj_Click(object sender, EventArgs e)
        {
            //redireciona par a tela da Alana/Cadastro CNPJ
        }

        private void btn_cpf_Click(object sender, EventArgs e)
        {
            //redireciona par a tela da Bea/Cadastro CPF
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //redireciona para tela da Luiza/Login
            frmLogin frm =new frmLogin();
            this.Hide();
            frm.Show();

        }

       
    }
}
