using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using BlazorPrimerParcial19DeFebero2020.Models;
using BlazorPrimerParcial19DeFebero2020.Data;

namespace BlazorPrimerParcial19DeFebero2020.Controllers
{
    public class AsignaturasControllers
    {
        public Asignaturas BuscarAsignaturas(int id)
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

        public List<Asignaturas> GetList(Expression<Func<Asignaturas,bool>> expression)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Asignaturas.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
