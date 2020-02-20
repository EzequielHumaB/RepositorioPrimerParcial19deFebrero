using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Inscripcion { 
 
        [Key]
        [Range(0,10000000000,ErrorMessage ="El Id no puede ser menor cero")]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="El campo semestre no puede estar vacio")]
        public string Semestre { get; set; }
    
        public decimal Limite { get; set; }
        [Required(ErrorMessage = "El campo debe Tomados en el semestre debe ser un numero")]
        [Range(1,100000,ErrorMessage ="El campo Tomados en el semestre debe estar entre 1 y 27")]
        public decimal Tomados { get; set; }
        public decimal Disponibles { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
        }

    }
}
