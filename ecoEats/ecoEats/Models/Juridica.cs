using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ecoEats.Models
{
    public class Juridica
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Column("razao_social")]
        public string Razao_social { get; set; }

        [Column("fk_pj_user")]
        public int Fk_pj_user { get; set; }
    }
}
