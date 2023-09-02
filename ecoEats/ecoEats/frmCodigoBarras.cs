﻿using ecoEats.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ecoEats
{
    public partial class frmCodigoBarras : Form
    {
        public frmCodigoBarras()
        {
            InitializeComponent();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {         
            string cod = textBoxDigCod.Text;

            if (cod == "")
            {
                MessageBox.Show("Digite algum código de barras");
                return;
            }

           
              /// Form formProduto = new FormProduto (cod);
             ///  formProduto.Show();

            ///MessageBox.Show("Código:" + cod);


            

            
        
             
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
           

            
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
