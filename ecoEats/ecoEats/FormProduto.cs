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

                foreach (Produto p in produto)
                {


                    if (p.fabricacao == null || p.data_validade == null || p.valor_produto == 0 || p.descricao == null || p.lote == null || p.categoria_produto == null)
                    {
                        if (p.fabricacao == null)
                        {
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

                string queryImpacto = "SELECT i.carbono, i.cultivo, i.embalagem, i.perdas, i.impacto, i.agua FROM impactos_ambientais AS i WHERE i.fk_impact_prod =" + this.prodId + ";";
                List<ImpactoAmbiental> impactos = db.Database.SqlQuery<ImpactoAmbiental>(queryImpacto).ToList();
                foreach (ImpactoAmbiental i in impactos)
                {
                    


                }

                //CARREGANDO INFORMAÇÕES DO VALOR NUTRICIONAL:
                string queryNutricional = "SELECT n.valor_energetico, n.proteinas, n.gorduras_totais, n.carboidrato, n.acucares FROM nutricional AS n WHERE n.fk_nutri_prod=" + this.prodId + ";";
                List<ValoresNutricionais> nutri = db.Database.SqlQuery<ValoresNutricionais>(queryNutricional).ToList();
                foreach(ValoresNutricionais n in nutri)
                {
                    lEnergetico.Text=n.valor_energetico.ToString();
                    lGordura.Text=n.gorduras_totais.ToString();
                    lProt.Text=n.proteinas.ToString();
                    lAcucar.Text=n.acucares.ToString();
                    lCarbo.Text=n.carboidrato.ToString();
                }

                // CALCULANDO O SCORE
               


            }
        }
        private double calculaAmbiental(double carbono, double agua, double cultivo, double embalagem, double perdas)
        {
            double res;
            res = (carbono * 2 + agua * 2 + cultivo + embalagem + perdas) / 6;
        return res;
        }
        private double calculaNutricional(double energia, double proteina, double gordura, double carb, double sugar)
        {
            double res;
            res = (energia+proteina+gordura+carb+sugar) / 5;
        return res;
        }
        private double score(double ambiental,double nutricional)
        {
            double res;
            res = (ambiental * 0.6) + (nutricional * 0.4) / 2;
            return res;
        }
        private string InterpretarScore(double score)
        {
            using (MyDbContext db = new MyDbContext())
            {
                string query;
                if (score <= 20)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com alto impacto ambiental e baixo valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo0;
                    return "Produto com alto impacto ambiental e baixo valor nutricional.";
                }
                else if (score <= 40)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com médio impacto ambiental e valor nutricional moderado.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    return "Produto com médio impacto ambiental e valor nutricional moderado.";
                }
                else if (score <= 60)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com impacto ambiental razoável e valor nutricional razoável.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    return "Produto com impacto ambiental razoável e valor nutricional razoável.";
                }
                else if (score <= 80)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com baixo impacto ambiental e bom valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    return "Produto com baixo impacto ambiental e bom valor nutricional.";
                }
                else
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com muito baixo impacto ambiental e excelente valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    return "Produto com muito baixo impacto ambiental e excelente valor nutricional.";
                }
            }
        }
    }

  
    }

