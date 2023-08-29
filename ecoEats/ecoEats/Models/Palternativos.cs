using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoEats.Models
{
    public class Palternativos
    {

        [Column("id")]
        public int Id { get; set; }


        [Column("nome")]
        public string nome { get; set; }


        [Column("diferenca")]
        public string diferenca { get; set; }


        [Column("fk_alternativo_prod")]
        public int fk_alternativo_prod { get; set; }
















    }
}
