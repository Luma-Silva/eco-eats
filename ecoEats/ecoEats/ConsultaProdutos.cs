using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ecoEats
{
    public partial class ConsultaProdutos : Form
    {
        public ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {

            // Define o tamanho de fonte padrão para todos os controles (pode ajustar o tamanho conforme necessário)
            Font fontePadrao = new Font("Source Code Pro Semibold", 10, FontStyle.Regular);
         
             
         

            // Calcula a posição para centralizar o formulário na tela
            int x = (Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2;

            // Ajusta a posição do formulário
            panel1.Location = new Point(x, y);


            panel1.BackColor = this.BackColor;








            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM clienteP;";

              //  List<ClienteP> clienteP = db.Database.SqlQuery<ClienteP>(query).ToList();

              //  panel1 = clienteP;

            }



        }
    }
}
