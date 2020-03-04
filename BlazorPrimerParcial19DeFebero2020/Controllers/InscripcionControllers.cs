using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlazorPrimerParcial19DeFebero2020.Models;
using BlazorPrimerParcial19DeFebero2020.Data;
namespace BlazorPrimerParcial19DeFebero2020.Controllers
{
    public class InscripcionControllers
    {


        public bool Insertar(Inscripcion inscripcion)
        {
            bool paso = true;
            Contexto contexto = new Contexto();
            try
            {
                if (inscripcion.InscripcionId == 0)
                    Guardar(inscripcion);

                else if (Buscar(inscripcion.InscripcionId) != null)
                    Modificar(inscripcion);

                else
                    paso = false;
            }
            catch
            {
                throw;
            }
            return paso;
        }



        private bool Guardar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {


                contexto.Inscripcion.Add(inscripcion);
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }

            return paso;
        }


        private bool Modificar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }

            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Inscripcion inscripcion = contexto.Inscripcion.Find(id);
                if (inscripcion != null)
                {
                    contexto.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
                else
                {
                    paso = false;
                }

            }
            catch
            {
                throw;
            }

            return paso;
        }


        public Inscripcion Buscar(int id)
        {
            Inscripcion inscripcion = new Inscripcion();
            Contexto contexto = new Contexto();
            try
            {
                inscripcion = contexto.Inscripcion.Find(id);
            }
            catch
            {
                throw;
            }

            return inscripcion;
        }

        public List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> expression)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Inscripcion.Where(expression).ToList();
            }
            catch
            {
                throw;
            }

            return lista;
        }

    }
}