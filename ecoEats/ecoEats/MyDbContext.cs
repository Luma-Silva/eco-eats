using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ecoEats.Models;
using MySqlX.XDevAPI;

namespace ecoEats
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyDbContext") { }


        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasMany(e => e.usuarios)
                .WithMany(t => t.produtos)
                .Map(et =>
                {
                    et.MapLeftKey("fk_cp_prod");
                    et.MapRightKey("fk_cp_user");
                    et.ToTable("cliente_produto");
                });
        }
    }
}
