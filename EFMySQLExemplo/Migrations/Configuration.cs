using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
//using MySql.Data.Entity; // Add this using
using MySql.Data.EntityFramework;

namespace EFMySQLExemplo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFMySQLExemplo.Contexto.MeuContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(EFMySQLExemplo.Contexto.MeuContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
