using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppSegundapractica20febrero.Models;

namespace BlazorAppSegundapractica20febrero.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite(@"Data Source = Database/PruebaparaahoritaDb"));
        }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
