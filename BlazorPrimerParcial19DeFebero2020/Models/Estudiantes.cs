using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string NombreEstudiante { get; set; }
        public int Matricula { get; set; }
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            NombreEstudiante = string.Empty;
            Matricula = 0;
            Balance = 0;
        }
    }
}
