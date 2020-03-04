using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BlazorPrimerParcial19DeFebero2020.Models;

namespace BlazorPrimerParcial19DeFebero2020.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite("Data Source = Database/PrimerParcial19DeFebrero2020DbSegundaVersion5"));
        }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }

        public DbSet<Asignaturas> Asignaturas { get; set; }
    }
}
