using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoEats.Models
{
    public class Pagamento
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("forma_pagamento")]
        public string Forma_pagamento { get; set; }

        [Column("numero_cartao")]
        public string Numero_cartao { get; set; }

        [Column("nome_catao")]
        public string Nome_cartao { get; set; }

        [Column("cpf_titular")]
        public string Cpf_titular { get; set; }

        [Column("cvv")]
        public string Cvv { get; set; }

        [Column("fk_pag_pj")]
        public int Fk_pag_pj { get; set; }

        [Column("valor")]
        public int valor { get; set; }
    }
}

