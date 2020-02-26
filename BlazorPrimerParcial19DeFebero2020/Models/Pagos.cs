using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Pagos
    {
        [Key]
        [Required(ErrorMessage ="El Id debe ser un numero")]
        [Range(0,100000000000000000,ErrorMessage ="El campo Id no debe ser menor que cero")]
        public int PagoId { get; set; }
        [Required(ErrorMessage ="La inscripcionId debe ser un numero")]
        [Range(1,1000000000000000,ErrorMessage ="La inscripcionId debe ser mayor que cero")]
        public int InscripcionId { get; set; }
        public DateTime FechaPago { get; set; }
        [Required(ErrorMessage ="El monto de pago debe ser un numero")]
        [Range(1,10000000000000000000,ErrorMessage ="El monto de pago debe ser mayor que cero")]
        public decimal MontoPago { get; set; }

        public Pagos()
        {
            PagoId = 0;
            InscripcionId = 0;
            FechaPago = DateTime.Now;
            MontoPago = 0;
        }
    }
}
