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


        [Column("protein_g")]
        public string protein_g { get; set; }



        [Column("fat_total_g")]
        public string fat_total_g { get; set; }


        [Column("carbohydrates_total_g")]
        public string carbohydrates_total_g { get; set; }



        [Column("sugar_g")]
        public string sugar_g { get; set; }


        [Column("serving_size_g")]
        public string serving_size_g { get; set; }



        [Column("fat_saturated_g")]
        public int fat_saturated_g { get; set; }

        [Column("sodium_mg")]
        public string sodium_mg { get; set; }

        [Column("potassium_mg")]
        public string potassium_mg { get; set; }

        [Column("cholesterol_mg")]
        public string cholesterol_mg { get; set; }

        [Column("fiber")]
        public string fiber { get; set; }

        [Column("fk_nutri_prod")]
        public int fk_nutri_prod { get; set; }

        [Column("calories")]
        public string calories { get; set; }












    }
}
