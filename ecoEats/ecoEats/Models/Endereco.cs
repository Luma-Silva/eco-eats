using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEats.Models
{
    internal class Endereco
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("rua")]
        public string Rua { get; set; }

        [Column("numero")]
        public string Numero { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        public string Bairro { get; set;}

        [Column("fk_end_user")]
        public int Fk_end_user { get; set;}

        [Column("naturalidade")]
        public string Naturalidade { get;set; }

        [Column("uf")]
        public string Uf { get; set; }

    }
}
