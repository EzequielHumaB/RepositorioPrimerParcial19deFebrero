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
        public int PagoId { get; set; }
        public int InscripcionId { get; set; }
        public DateTime FechaPago { get; set; }
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
