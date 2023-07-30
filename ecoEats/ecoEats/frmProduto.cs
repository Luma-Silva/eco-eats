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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //esse if serve para verificar se o txt esta vazio se estiver ele vai aparecer a massage box 
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {

                MessageBox.Show("O Nome do Produto é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // o return sai do erro e segue o programa 


            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {

                MessageBox.Show("O Codigo do Produto é  obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //estou declarando as variaveis para elas ficarem salvas no Botão salvar
            String Validade = DTPValidade.Value.ToString("yyyy-MM-dd");
            String Fabricacao = DTPFabricacao.Value.ToString("yyyy-MM-dd");
            string codigo = txtCodigo.Text;
            string Lote = txtLote.Text;
            string Nome = txtNome.Text;
            string Valor = txtValor.Text;
            string Categoria = CBCategoria.SelectedItem.ToString();
            //na proxima linha eu fiz uma variavel para aparecer esta mensagem no mensagem boox.show
            // $ este simbolo de cifrão serve para concatenar a mensagem igual ao simbolo de +
            string mensagem = $"Nome do Produto: {Nome}\n" +

                              $"Código de Barras: {codigo}\n" +

                              $"Lote: {Lote}\n" +

                              $"Categoria do Produto:{Categoria}\n" +

                              $"Valor: {Valor:C}\n" +

                              $"Vencimento: {Validade}\n" +

                              $"Data de Fabricação: {Fabricacao}";

            //Ao inves do menssage box, jogar para o banco de dados (depois)
            // este MessageBoxButtons serve para eu criar uma caixa com o ok ou cancel

            // o messageBoxIcon serve para eu colocar o simbolo de informação na message show
            MessageBox.Show(mensagem, "Informações do Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);




        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //o empty significa vazio e o noww volta para data de hoje

            txtCodigo.Text = string.Empty;
            txtLote.Text = string.Empty;
            txtNome.Text = string.Empty;
            CBCategoria.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
            DTPValidade.Value = DateTime.Now;
            DTPFabricacao.Value = DateTime.Now;
        }
    }
}
