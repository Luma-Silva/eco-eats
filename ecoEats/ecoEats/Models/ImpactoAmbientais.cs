using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ecoEats.Models
{
    public class ImpactoAmbientais
    {
        [Column("id")]
        public int Id { get; set; }


        [Column("carbono")]
        public string carbono { get; set; }


        [Column("muda_terra_usada")]
        public string muda_terra_usada { get; set; }



        [Column("alimentacao_producao")]
        public string alimentacao_producao { get; set; }


        [Column("cultivo")]
        public string cultivo { get; set; }


        [Column("processo")]
        public string processo { get; set; }


        [Column("transportacao")]
        public string transportacao { get; set; }



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






    }
}
