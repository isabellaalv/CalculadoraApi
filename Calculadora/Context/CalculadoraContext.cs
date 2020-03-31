using Calculadora.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Context
{
    public class CalculadoraContext : DbContext
    {
        public DbSet<Operacao> Calculador { get; set; }

        public CalculadoraContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; initial catalog=Calculadora; Integrated Security=True");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Operacao>().HasData(new Operacao
            {

            });
           
        }
    }
}
