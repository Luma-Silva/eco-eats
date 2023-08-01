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
    public partial class frmHome : Form
    {
        public frmHome()
        {
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
    }
}
