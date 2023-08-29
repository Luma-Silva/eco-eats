using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoEats.Models
{
    public class ValoresNutricionais

    {


        [Column("id")]
        public string Id { get; set; }


        [Column("valor_energetico")]
        public string valor_energetico { get; set; }



        [Column("proteinas")]
        public string proteinas { get; set; }


        [Column("gorduras_totais")]
        public string gorduras_totais { get; set; }


        [Column("gorduras_saturadas")]
        public string gorduras_saturadas { get; set; }


        [Column("gorduras_trans")]
        public string gorduras_trans { get; set; }



        [Column("fibra")]
        public string fibra { get; set; }


        [Column("carboidrato")]
        public string carboidrato { get; set; }


        [Column("acucares")]
        public string acucares { get; set; }


        [Column("porcao")]
        public string porcao { get; set; }

        [Column("fk_nutri_prod")]
        public int fk_nutri_prod { get; set; }











    }
}
