using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Estudiantes
    {
        [Key]
        [Required(ErrorMessage ="El EstudianteId no debe ser menor que cero")]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage ="El nombre del estudiante no debe estar vacio")]
        public string NombreEstudiante { get; set; }
        [Required(ErrorMessage ="Los creditos deben ser un numero")]
        [Range(1,10000000000,ErrorMessage ="Los creditos deben ser mayor que cero")]
        public int Matricula { get; set; }
        [Required(ErrorMessage ="El balance debe ser un numero")]
        [Range(1,1000000000000000000,ErrorMessage ="El balance no puede ser menor que cero")]
        public decimal Balance { get; set; }

        public List<Asignaturas> Asignaturas { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            NombreEstudiante = string.Empty;
            Matricula = 0;
            Balance = 0;
            EstudianteId = 0;
            Asignaturas = new List<Asignaturas>();
        }
    }
}
