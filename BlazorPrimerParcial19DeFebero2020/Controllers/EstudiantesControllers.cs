using System;
using System.Collections.Generic;
using System.Linq;
using BlazorPrimerParcial19DeFebero2020.Models;
using Microsoft.EntityFrameworkCore;
using BlazorPrimerParcial19DeFebero2020.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Controllers
{
    public class EstudiantesControllers
    {
        private bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Estudiantes.Add(estudiantes);
                paso = contexto.SaveChanges() > 0;
            }catch
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(estudiantes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
                
            }catch
            {
                throw;
            }
            return paso;
        }

        public bool Insertar(Estudiantes estudiantes)
        {
            bool paso = true;
            
            if(estudiantes.EstudianteId==0)
            {
                Guardar(estudiantes);
            } else
            {
                if(Buscar(estudiantes.EstudianteId)==null)
                {
                    paso = false;
                } else
                {
                    Modificar(estudiantes);
                }
            }

            return paso;
        }


        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Estudiantes estudiantes = contexto.Estudiantes.Find(id);
                contexto.Entry(estudiantes).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }catch
            {
                throw;
            }
            return paso;
        }

        public Estudiantes Buscar(int id)
        {
            Estudiantes estudiantes = new Estudiantes();
            Contexto contexto = new Contexto();
            try
            {
                estudiantes = contexto.Estudiantes.Find(id);
                estudiantes.Asignaturas.Count();             
            }catch
            {
                throw;
            }
            return estudiantes;
        }

        public List<Estudiantes> GetList(Expression<Func<Estudiantes,bool>> expression)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Estudiantes.Where(expression).ToList();
                
            }catch
            {
                throw;
            }
            return lista;
        }

       

    }
}
