using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ecoEats.Models
{
    public class Usuario
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Name { get; set; }

        [Column("idade")]
        public int Idade { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("senha")]
        public string Senha { get; set; }


        public virtual ICollection<Produto> produtos
        { get; set; }
    } 
}
