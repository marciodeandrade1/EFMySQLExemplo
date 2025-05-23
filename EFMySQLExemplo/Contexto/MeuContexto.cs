using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMySQLExemplo.Models;

namespace EFMySQLExemplo.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("name=MeuContexto")
        {
            //Configuração para MySql
            Database.SetInitializer(new CreateDatabaseIfNotExists<MeuContexto>());
        }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuração para o nome da tabela no banco de dados
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            base.OnModelCreating(modelBuilder);
        }
    }
}
