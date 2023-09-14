using ecoEats.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ecoEats.Models;
using Org.BouncyCastle.Utilities.Collections;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using System.Security.Policy;
using Newtonsoft.Json;

namespace ecoEats
{
    public partial class frmProduto : Form
    {
        int prodId;
        frmHome pai;
        bool cnpj;
        public frmProduto(int prodId, frmHome pai, bool cnpj)
        {
            InitializeComponent();
            this.prodId = prodId;
            this.pai = pai;
            this.cnpj = cnpj;
        }



        private async void FormProduto_Load(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                string query;
                query = "SELECT p.id,p.codigo_barras, p.nome,p.score, p.data_validade,p.fabricacao, p.valor_produto, p.descricao, p.lote, p.categoria_produto FROM produtos AS p WHERE p.id =" + this.prodId + " LIMIT 1;";
                Produto p = db.Database.SqlQuery<Produto>(query).SingleOrDefault();

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

                }

                lCod.Text = p.codigo_barras;
                lCategoria.Text = p.categoria_produto;
                lDescricao.Text = p.descricao;
                lFab.Text = p.fabricacao.ToString();
                lLote.Text = p.lote;
                lPreco.Text = p.valor_produto.ToString();
                lValidade.Text = p.data_validade.ToString();
                nome_produto.Text = p.nome.ToString();


                



                string queryImpacto = "SELECT i.carbono, i.cultivo, i.embalagem, i.perdas, i.impacto, i.agua FROM impactos_ambientais AS i WHERE i.fk_impact_prod =" + this.prodId + ";";
                ImpactoAmbiental i = db.Database.SqlQuery<ImpactoAmbiental>(queryImpacto).SingleOrDefault();

                if (i.carbono == null || i.cultivo == null || i.embalagem == null || i.perdas == null || i.impacto == null || i.agua == null)
                {



                    if (i.carbono == null)
                    {
                        i.carbono = "N/A";
                    }
                    if (i.cultivo == null)
                    {
                        i.cultivo = "N/A";
                    }
                    if (i.embalagem == null)
                    {
                        i.embalagem = "N/A";
                    }
                    if (i.perdas == null)
                    {
                        i.perdas = "N/A";
                    }
                    if (i.impacto == null)
                    {
                        i.impacto = "N/A";
                    }
                    if (i.agua == null)
                    {
                        i.agua = "N/A";
                    }
                }

                lImpacto.Text = i.impacto.ToString();
                lAgua.Text = i.agua.ToString();
                lCarbono.Text = i.carbono.ToString();
                lCultivo.Text = i.cultivo.ToString();
                lEmbalagem.Text = i.embalagem.ToString();
                lPerdas.Text = i.perdas.ToString();

                string queryNutricional = "SELECT calories, protein_g, fat_total_g, carbohydrates_total_g, sugar_g FROM nutricional WHERE fk_nutri_prod=" + this.prodId + " LIMIT 1;";
                ValoresNutricionais n = db.Database.SqlQuery<ValoresNutricionais>(queryNutricional).SingleOrDefault();

                if(n == null)
                {
                    string apiKey = "b8v773NKkAPR8mfiYhOVOw==S8saUikuTvMsL5Iy";
                    string url = $"https://api.api-ninjas.com/v1/nutrition?query={nome_produto.Text}";
                    //consulta a API para trazer o dado nutricional e salvar no banco de dados
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

                        try
                        {
                            HttpResponseMessage response = await client.GetAsync(url);

                            if (response.IsSuccessStatusCode)
                            {
                                string json = await response.Content.ReadAsStringAsync();

                                var nutritionalData = JsonConvert.DeserializeObject<ValoresNutricionais>(json);

                                if (nutritionalData != null)
                                {
                                    n = nutritionalData;
                                }
                                // Aqui você pode decidir como deseja salvar os dados na sua base de dados.
                                string queryNutri = "INSERT INTO nutricional( fk_nutri_prod,calories, protein_g, fat_total_g, carbohydrates_total_g, sugar_g,serving_size_g,fat_saturated_g,sodium_mg,potassium_mg,cholesterol_mg,fiber)" +
                                     " VALUES (" + this.prodId + ","+n.calories+","+n.protein_g+","+n.fat_total_g+","+n.carbohydrates_total_g+","+n.sugar_g+","+n.fat_saturated_g+","+n.sodium_mg+","+n.potassium_mg+","+n.cholesterol_mg+","+n.fiber+");" ; 
                                int nRowAfe = db.Database.ExecuteSqlCommand(queryNutri);

                                MessageBox.Show("Dados Nutricionais: " + json);

                            }
                            else
                            {
                                MessageBox.Show($"Erro na solicitação: {response.StatusCode}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao buscar os dados nutricionais: " + ex.Message);
                        }
                    }

                }

                if (n.calories == null || n.protein_g == null || n.fat_total_g == null || n.carbohydrates_total_g == null || n.sugar_g == null)
                {
                    if (n.calories == null)
                    {
                        n.calories = "N/A";
                    }
                    if (n.protein_g == null)
                    {
                        n.protein_g = "N/A";
                    }
                    if (n.fat_total_g == null)
                    {
                        n.fat_total_g = "N/A";
                    }
                    if (n.carbohydrates_total_g == null)
                    {
                        n.carbohydrates_total_g = "N/A";
                    }
                    if (n.sugar_g == null)
                    {
                        n.sugar_g = "N/A";
                    }

                }

                lEnergetico.Text = n.calories.ToString();
                lGordura.Text = n.fat_total_g.ToString();
                lProt.Text = n.protein_g.ToString();
                lAcucar.Text = n.sugar_g.ToString();
                lCarbo.Text = n.carbohydrates_total_g.ToString();
                
                        

                
                double carbono = Convert.ToDouble(lCarbono.Text);
                double cultivo = Convert.ToDouble(lCultivo.Text.Split('%')[0]) / 100;
                double perdas = Convert.ToDouble(lPerdas.Text.Split('%')[0]) / 100;
                double embalagem = Convert.ToDouble(lEmbalagem.Text.Split('%')[0]) / 100;
                double agua = Convert.ToDouble(lAgua.Text.Split(' ')[0]);



                double mediaAmbiental = calculaAmbiental(carbono, agua, cultivo, embalagem, perdas);
                //
                double energia = Convert.ToDouble(lEnergetico.Text);
                double gordura = Convert.ToDouble(lGordura.Text);
                double proteina = Convert.ToDouble(lProt.Text);
                double acucar = Convert.ToDouble(lAcucar.Text);
                double carboidrato = Convert.ToDouble(lCarbo.Text);
                double mediaNutricional = calculaNutricional(energia, proteina, gordura, carboidrato, acucar);
                double scoreFinal = score(mediaAmbiental, mediaNutricional);

                string queryScore = "UPDATE produtos SET score = '" + scoreFinal.ToString() + "' WHERE id = " + this.prodId + ";";
                int nRowAfetted = db.Database.ExecuteSqlCommand(queryScore);
                lInterpretacao.Text = InterpretarScore(scoreFinal);
                lScore.Text = scoreFinal.ToString("0.0");
                this.Text = nome_produto.Text;

                if (cnpj == false)
                {
                    btnComprarSelo.Enabled = false;
                }





            }
        }



        public void btn_click(object sender, EventArgs e)
        {



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
            res = (energia + proteina + gordura + carb + sugar) / 5;
            return res;
        }
        private double score(double ambiental, double nutricional)
        {
            double res;
            res = (ambiental * 0.6) + (nutricional * 0.4) / 2;
            return res;
        }
        private string InterpretarScore(double score)
        {
            double preco;
            using (MyDbContext db = new MyDbContext())
            {
                string query;
                if (score <= 20)
                {
                    preco=500;
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com alto impacto ambiental e baixo valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo0;
                    picScore.BackgroundImage = Resources.score0;
                    lblPreco.Text = preco.ToString();
                    return "Produto com alto impacto ambiental e baixo valor nutricional.";
                }
                else if (score <= 40)
                {
                    preco = 1000;
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com médio impacto ambiental e valor nutricional moderado.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    picScore.BackgroundImage = Resources.score50;
                    lblPreco.Text = preco.ToString();
                    return "Produto com médio impacto ambiental e valor nutricional moderado.";
                }
                else if (score <= 60)
                {
                    preco = 1000;
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com impacto ambiental razoável e valor nutricional razoável.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    picScore.BackgroundImage = Resources.score50;
                    lblPreco.Text = preco.ToString();
                    return "Produto com impacto ambiental razoável e valor nutricional razoável.";
                }
                else if (score <= 80)
                {
                    preco = 1200;
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com baixo impacto ambiental e bom valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    picScore.BackgroundImage = Resources.score100;
                    lblPreco.Text = preco.ToString();
                    return "Produto com baixo impacto ambiental e bom valor nutricional.";
                }
                else
                {
                    preco = 1200;
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com muito baixo impacto ambiental e excelente valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    picScore.BackgroundImage = Resources.score100;
                    lblPreco.Text = preco.ToString();
                    return "Produto com muito baixo impacto ambiental e excelente valor nutricional.";
                }
            }
        }



        private void btnComprarSelo_Click(object sender, EventArgs e)
        {
            frmPagamento frm = new frmPagamento(this.prodId);
            this.pai.mostraFormExterno(frm);

        }
    }
}
