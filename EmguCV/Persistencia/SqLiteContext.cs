using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_EmguCV.Modelo;

namespace Teste_EmguCV.Persistencia
{
    class SqLiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            {
                string connectionStringBuilder = new SqliteConnectionStringBuilder() { DataSource = "..\\..\\Persistencia\\SqLiteDataBase.db" }.ToString();
                var connection = new SqliteConnection(connectionStringBuilder);
                optionsBuilder.UseSqlite(connection);
            }
        }

        public void Created()
        {
            Database.EnsureCreated();
        }

        public DbSet<ImagemDb> Imagens { get; set; }

    }
}
