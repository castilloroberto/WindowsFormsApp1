using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class DataAcces
    {

        public static List<Productos> GetProductos()
        {
            List<Productos> productos = new List<Productos>();
            using(Netflix_dbEntities db = new Netflix_dbEntities())
	        {
                //linq
                var lista = from item in db.Productos
                            select item;

                productos = lista.ToList<Productos>();
	        }

            return productos;

        }

        public static void InsertProduct(Productos product)
        {
            using (Netflix_dbEntities db = new Netflix_dbEntities())
            {
                
            }
        }

        public static void InsertCategory(Categorias category)
        {
            using (Netflix_dbEntities db = new Netflix_dbEntities())
            {

            }
        }
        public static List<Categorias> GetCategorias()
        {
            List<Categorias> categorias = new List<Categorias>();
            using (Netflix_dbEntities db = new Netflix_dbEntities())
            {
                //linq
                var lista = from item in db.Categorias
                            select item;

                categorias = lista.ToList<Categorias>();
            }

            return categorias;
        }
    }
}
