using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppSegundapractica20febrero.Models;
using BlazorAppSegundapractica20febrero.Data;

namespace BlazorAppSegundapractica20febrero.Controllers
{
    public class Controllador
    {
        public bool Guardar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Articulos.Add(articulos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Articulos Buscar(int id)
        {
            Articulos articulos = new Articulos();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return articulos;
        }
    }
}
