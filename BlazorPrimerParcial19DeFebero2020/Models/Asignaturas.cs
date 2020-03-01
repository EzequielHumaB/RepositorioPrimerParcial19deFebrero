using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Asignaturas
    {
        [Key]
        [Range(0, 10000000000000000000)]
        public int AsignaturaId { get; set; }
        [Required(ErrorMessage = "El codigo no puede estar vacio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "La descripcion no puede estar vacio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Los perrequisitos no pueden estar vacios")]
        public string PreRequisitos { get; set; }
        [Range(1, 1000000000, ErrorMessage = "Los creditos no pueden ser igual a cero")]
        public int Creditos { get; set; }
        [Required(ErrorMessage = "El EstudianteId debe ser un numero")]
        [ForeignKey("EstudianteFK")]

        public Estudiantes Estudiantes { get; set; }
        public int EstudianteId { get; set; }


        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisitos = string.Empty;
            Creditos = 0;
            EstudianteId = 0;
        }

        public Asignaturas(int AsignaturaIds, string Codigos, string Descripcions, string PreRequesitoss, int Creditoss, int IdEstudiante)
        {
            AsignaturaId = AsignaturaIds;
            Codigo = Codigos;
            Descripcion = Descripcions;
            PreRequisitos = PreRequesitoss;
            Creditos = Creditoss;
            EstudianteId = IdEstudiante;
        }
    }
}
