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




namespace ecoEats
{
    public partial class FormProduto : Form
    {
        int prodId;
        public FormProduto(int prodId)
        {
            InitializeComponent();
            this.prodId = prodId;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {

                string query;
                query = "SELECT p.codigo_barras, p.nome, COALESCE(p.data_validade, 'N/A'),COALESCE(p.fabricacao, 'N/A'),COALESCE(p.valor_produto, 'N/A'),COALESCE(p.descricao, 'N/A'),COALESCE(p.lote, 'N/A'),COALESCE(p.categoria_produto, 'N/A') FROM produtos AS p WHERE p.id =" + this.prodId + ";";
                List<Produto> produto = db.Database.SqlQuery<Produto>(query).ToList();

                foreach (Produto p in produto) {
                 
                 
                    if (p.fabricacao == null || p.data_validade==null || p.valor_produto==0 || p.descricao==null || p.lote==null || p.categoria_produto==null )
                    {
                        if (p.fabricacao == null) {
                            p.fabricacao = "N/A";
                        }
                        if (p.data_validade == null)
                        {
                            p.data_validade = "N/A";
                        }
                        if (p.valor_produto == 0)
                        {
                            p.valor_produto = 0;
                        }
                        if (p.descricao == null)
                        {
                            p.descricao = "N/A";
                        }
                        if (p.lote == null)
                        {
                            p.lote = "N/A";
                        }
                        if (p.categoria_produto == null)
                        {
                            p.categoria_produto = "N/A";
                        }
                       
                            lCod.Text = p.codigo_barras;
                            lCategoria.Text = p.categoria_produto;
                            lDescricao.Text = p.descricao;
                            lFab.Text = p.fabricacao.ToString();
                            lLote.Text = p.lote;
                            lPreco.Text = p.valor_produto.ToString();
                        lValidade.Text = p.data_validade.ToString();
                    }
                    else
                    {
                        lCod.Text = p.codigo_barras;
                        lCategoria.Text = p.categoria_produto;
                        lDescricao.Text = p.descricao;
                        lFab.Text = p.fabricacao.ToString();
                        lLote.Text = p.lote;
                        lPreco.Text = p.valor_produto.ToString();
                        lValidade.Text = p.data_validade.ToString();

                    }
                   

                }
                
               string  queryImpacto = "SELECT i.carbono, i.cultivo, i.embalagem, i.perdas, i.impacto, i.agua FROM impactos_ambientais AS i WHERE i.fk_impact_prod =" + this.prodId + ";";
                List<ImpactoAmbiental> impactos = db.Database.SqlQuery<ImpactoAmbiental>(queryImpacto).ToList();
                foreach(ImpactoAmbiental i in impactos)
                {
                    i.lista();
                    test.Text = i.lista().ToString();


                    }
                }


            }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

      
    }

