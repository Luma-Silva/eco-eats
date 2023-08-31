using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ecoEats.Models
{
    public class Selo
    {
        [Column ("id") ]
        public int Id { get; set; }
        [Column("fk_produto_id")]
        public string Produto_id { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("imagem")]
        public string Imagem { get; set; }
    }
}
