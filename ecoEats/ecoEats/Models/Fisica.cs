using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ecoEats.Models
{
    public class Fisica
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("data_nascimento")]
        public DateTime Data_Nascimento { get; set; }

        [Column("sexo")]
        public string Sexo { get; set; }

        [Column("fk_pf_user")]
        public int Fk_pf_user { get; set; }
    }
}
