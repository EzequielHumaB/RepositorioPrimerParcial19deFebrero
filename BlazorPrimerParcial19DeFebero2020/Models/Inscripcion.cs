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
        [Range(minimum:10,maximum:300,ErrorMessage ="El demasiado corto")]
        public string Semestre { get; set; }

        [Range(1,50,ErrorMessage ="El limite de creditos no debe estar entre")]
        public decimal Limite { get; set; }
        [Required(ErrorMessage = "El campo debe Tomados en el semestre debe ser un numero")]
        [Range(1,100000,ErrorMessage ="El campo Tomados en el semestre debe estar entre 1 y 27")]
        public decimal Tomados { get; set; }
        public decimal Disponibles { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }


        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
            Fecha = DateTime.Now;
            Balance = 0;
            Monto = 0;
        }

    }
}
