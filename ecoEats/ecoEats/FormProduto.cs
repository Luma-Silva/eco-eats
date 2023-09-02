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
                query = "SELECT p.codigo_barras, p.nome, p.data_validade,p.fabricacao, p.valor_produto, p.descricao, p.lote, p.categoria_produto FROM produtos AS p WHERE p.id =" + this.prodId + ";";
                List<Produto> produto = db.Database.SqlQuery<Produto>(query).ToList();
                foreach (Produto p in produto)
                {
                    if (p.fabricacao == null || p.data_validade == null || p.valor_produto == 0 || p.descricao == null || p.lote == null || p.categoria_produto == null)
                    {
                        if(p.fabricacao == null)
                        {
                            p.fabricacao = "N/A";
                        }
                        if(p.data_validade == null)
                        {
                            p.data_validade = "N/A";
                        }
                        if(p.valor_produto == 0)
                        {
                            p.valor_produto = 0;
                        }
                        if(p.descricao == null)
                        {
                            p.descricao = "N/A";
                        }
                        if(p.lote == null)
                        {
                            p.lote = "N/A";
                        }
                        if(p.categoria_produto == null)
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
                        nome_produto.Text = p.nome.ToString();
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
                        nome_produto.Text = p.nome.ToString();


            }
        }

                string queryImpacto = "SELECT i.carbono, i.cultivo, i.embalagem, i.perdas, i.impacto, i.agua FROM impactos_ambientais AS i WHERE i.fk_impact_prod =" + this.prodId + ";";
                List<ImpactoAmbiental> impactos = db.Database.SqlQuery<ImpactoAmbiental>(queryImpacto).ToList();
                foreach (ImpactoAmbiental i in impactos)
                {
                    if(i.carbono == null || i.cultivo == null || i.embalagem == null || i.perdas == null || i.impacto == null || i.agua == null)
                    {

                        if(i.carbono == null)
                        {
                            i.carbono = "N/A";
                        }
                        if(i.cultivo == null)
                        {
                            i.cultivo = "N/A";
                        }
                        if(i.embalagem == null)
                        {
                            i.embalagem = "N/A";
                        }
                        if(i.perdas == null)
                        {
                            i.perdas = "N/A";
                        }
                        if(i.impacto == null)
                        {
                            i.impacto = "N/A";
                        }
                        if(i.agua == null)
                        {
                            i.agua = "N/A";
                        }
                        lImpacto.Text = i.impacto.ToString();
                        lAgua.Text = i.agua.ToString();
                        lCarbono.Text = i.carbono.ToString();
                        lCultivo.Text = i.cultivo.ToString();
                        lEmbalagem.Text = i.embalagem.ToString();
                        lPerdas.Text = i.perdas.ToString();
                    }
                    else
                    {
                        lImpacto.Text = i.impacto.ToString();
                        lAgua.Text = i.agua.ToString();
                        lCarbono.Text = i.carbono.ToString();
                        lCultivo.Text = i.cultivo.ToString();
                        lEmbalagem.Text = i.embalagem.ToString();
                        lPerdas.Text = i.perdas.ToString();
                        
                    }
                }

                string queryNutricional = "SELECT n.valor_energetico, n.proteinas, n.gorduras_totais, n.carboidrato, n.acucares FROM nutricional AS n WHERE n.fk_nutri_prod=" + this.prodId + ";";
                List<ValoresNutricionais> nutri = db.Database.SqlQuery<ValoresNutricionais>(queryNutricional).ToList();
                foreach(ValoresNutricionais n in nutri)
                {
                    if(n.valor_energetico == null || n.proteinas == null || n.gorduras_totais == null || n.carboidrato == null || n.acucares == null)
                    {
                        if(n.valor_energetico == null)
                        {
                            n.valor_energetico = "N/A";
                        }
                        if(n.proteinas == null)
                        {
                            n.proteinas = "N/A";
                        }
                        if(n.gorduras_totais == null)
                        {
                            n.gorduras_totais = "N/A";
                        }
                        if(n.carboidrato == null)
        {
                            n.carboidrato = "N/A";
        }
                        if(n.acucares == null)
        {
                            n.acucares = "N/A";
                        }
                        lEnergetico.Text = n.valor_energetico.ToString();
                        lGordura.Text = n.gorduras_totais.ToString();
                        lProt.Text = n.proteinas.ToString();
                        lAcucar.Text = n.acucares.ToString();
                        lCarbo.Text = n.carboidrato.ToString();
                    }
                    else
                    lEnergetico.Text=n.valor_energetico.ToString();
                    lGordura.Text=n.gorduras_totais.ToString();
                    lProt.Text=n.proteinas.ToString();
                    lAcucar.Text=n.acucares.ToString();
                    lCarbo.Text=n.carboidrato.ToString();
                    
                }
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
                    picScore.BackgroundImage = Resources.score0;
                    return "Produto com alto impacto ambiental e baixo valor nutricional.";
                }
                else if (score <= 40)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com médio impacto ambiental e valor nutricional moderado.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    picScore.BackgroundImage = Resources.score50;
                    return "Produto com médio impacto ambiental e valor nutricional moderado.";
                }
                else if (score <= 60)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com impacto ambiental razoável e valor nutricional razoável.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo50;
                    picScore.BackgroundImage = Resources.score50;
                    return "Produto com impacto ambiental razoável e valor nutricional razoável.";
                }
                else if (score <= 80)
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com baixo impacto ambiental e bom valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    picScore.BackgroundImage = Resources.score100;
                    return "Produto com baixo impacto ambiental e bom valor nutricional.";
                }
                else
                {
                    query = "INSERT INTO selo(fk_produto_id,categoria) VALUES (" + this.prodId + ", 'Produto com muito baixo impacto ambiental e excelente valor nutricional.')";
                    int nRowAfetted = db.Database.ExecuteSqlCommand(query);
                    picSelo.BackgroundImage = Resources.selo100;
                    picScore.BackgroundImage = Resources.score100;
                    return "Produto com muito baixo impacto ambiental e excelente valor nutricional.";
                }
            }
        }

        private void btnComprarSelo_Click(object sender, EventArgs e)
        {
            frmPagamento frm = new frmPagamento();
            frm.Show();
        }
    }  
}

