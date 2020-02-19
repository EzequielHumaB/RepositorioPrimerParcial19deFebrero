using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppSegundapractica20febrero.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Range(1,10000000000000000)]
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal PorCientoGanancia { get; set; }

        [Range(typeof(DateTime), "1-1-2000","12-12-2026")]
        public DateTime Fecha { get; set; }


     
        public DateTime Fecha2 { get; set; }
        public Articulos()
        {
            ArticuloId = 0;
            Costo = 0;
            Precio = 0;
            PorCientoGanancia = 0;
        }


    }
}
