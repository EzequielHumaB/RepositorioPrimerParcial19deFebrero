﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPrimerParcial19DeFebero2020.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string PreRequisitos { get; set; }
        public int Creditos { get; set; }

        public int EstudianteId { get; set; }


        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisitos = string.Empty ;
            Creditos = 0;
        }
    }
}
