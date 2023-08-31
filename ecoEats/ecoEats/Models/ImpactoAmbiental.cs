using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ecoEats.Models
{
    public class ImpactoAmbiental
    {
        [Column("id")]
        public int Id { get; set; }


        [Column("carbono")]
        public string carbono { get; set; }



        [Column("cultivo")]
        public string cultivo { get; set; }



        [Column("embalagem")]
        public string embalagem { get; set; }



        [Column("perdas")]
        public string perdas { get; set; }



        [Column("impacto")]
        public string impacto { get; set; }



        [Column("agua")]
        public string agua { get; set; }


        [Column("fk_impact_prod")]
        public int fk_impact_prodd { get; set; }

        public Array lista()
        {
            string[] lista = new string[6] ;
            lista.Append(this.carbono);
            lista.Append(this.cultivo);
            lista.Append(this.embalagem);
            lista.Append(this.perdas);
            lista.Append(this.impacto);
            lista.Append(this.agua);
            return lista;

           
        }





    }
}
