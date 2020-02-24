using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPrimerParcial19DeFebero2020.Data;
using BlazorPrimerParcial19DeFebero2020.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace BlazorPrimerParcial19DeFebero2020.Controllers
{
    public class PagosControllers
    {

        public bool Insertar(Pagos pagos)
        {
            bool paso = true;

            if(pagos.PagoId==0)
            {
                Guardar(pagos);
            } else
            {
                if(Buscar(pagos.PagoId)==null)
                {
                    paso = false;
                } else
                {
                    Modificar(pagos);
                }
            }
            return paso;

        }

        private bool Guardar(Pagos pagos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Pagos.Add(pagos);
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(pagos).State = EntityState.Modified;
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
                Pagos pagos = contexto.Pagos.Find(id);
                contexto.Entry(pagos).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            return paso;
        }

        public Pagos Buscar(int id)
        {
            Pagos pagos = new Pagos();
            Contexto contexto = new Contexto();
            try
            {
                pagos = contexto.Pagos.Find(id);
            }
            catch
            {
                throw;
            }
            return pagos;
        }

        public List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pagos.Where(expression).ToList();
            }
            catch
            {
                throw;
            }
            return lista;
        }

    }
}
