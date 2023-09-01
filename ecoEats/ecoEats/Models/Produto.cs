using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoEats.Models
{
    public class Produto
    {

        [Column("id")]
        public int Id { get; set; }


        [Column("codigo_barras")]
        public string codigo_barras { get; set; }


        [Column("nome")]
        public string nome { get; set; }


        [Column("data_validade")]
        public string data_validade { get; set; }


        [Column("fabricacao")]

        public string fabricacao { get; set; }


        [Column("valor_produto")]
        public float? valor_produto { get; set; }


        [Column("descricao")]
        public string descricao { get; set; }


        [Column("lote")]
        public string lote { get; set; }


        [Column("categoria_produto")]
        public string categoria_produto { get; set; }


        [Column("score")]
        public float? score { get; set; }





























    }
}
