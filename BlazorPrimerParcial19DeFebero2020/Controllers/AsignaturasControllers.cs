using System;
using System.Collections.Generic;
using System.Linq;
using BlazorPrimerParcial19DeFebero2020.Models;
using BlazorPrimerParcial19DeFebero2020.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorPrimerParcial19DeFebero2020.Controllers
{
    public class AsignaturasControllers
    {
        public bool Insertar(Asignaturas Asignaturas)
        {
            bool paso = true;

            if (Asignaturas.AsignaturaId == 0)
            {
                Guardar(Asignaturas);
            }
            else
            {
                if (Buscar(Asignaturas.AsignaturaId) == null)
                {
                    paso = false;
                }
                else
                {
                    Modificar(Asignaturas);
                }
            }
            return paso;

        }

        private bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Asignaturas.Add(asignaturas);
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Asignaturas  Asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Asignaturas).State = EntityState.Modified;
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
                Asignaturas asignaturas = contexto.Asignaturas.Find(id);

                if(asignaturas!=null)
                {
                    contexto.Entry(asignaturas).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
               
            }
            catch
            {
                throw;
            }
            return paso;
        }

        public Asignaturas Buscar(int id)
        {
            Asignaturas asignaturas = new Asignaturas();
            Contexto contexto = new Contexto();
            try
            {
                asignaturas = contexto.Asignaturas.Find(id);
            }
            catch
            {
                throw;
            }
            return asignaturas;
        }

        public List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> expression)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Asignaturas.Where(expression).ToList();
            }
            catch
            {
                throw;
            }
            return lista;
        }


    }
}
