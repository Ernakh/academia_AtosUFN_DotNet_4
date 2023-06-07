using AulaEntityAtos.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEntityAtos
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["EntityAtos"];

                string retorno = "";

                if (settings != null)
                {
                    retorno = settings.ConnectionString;
                }

                optionsBuilder.UseSqlServer(retorno);

                optionsBuilder.UseLazyLoadingProxies();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.emails)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
