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
                query = "SELECT p.codigo_barras, p.nome, COALESCE(p.data_validade, 'N/A'),COALESCE(p.fabricacao, 'N/A'),COALESCE(p.valor_produto, 'N/A'),COALESCE(p.descricao, 'N/A'),COALESCE(p.lote, 'N/A'),COALESCE(p.categoria_produto, 'N/A') FROM produtos AS p WHERE p.id =" + this.prodId + ";";
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
            }
        }
    }
}

