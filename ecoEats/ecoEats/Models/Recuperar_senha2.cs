using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEats.Models
{
    public class Recuperar_senha2
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("token")]
        public string Token { get; set; }

        [Column("data_exp")]
        public DateTime data_exp { get; set; }

        [Column("fk_update_user")]
        public int fk_update_user { get; set; }
    }
}
