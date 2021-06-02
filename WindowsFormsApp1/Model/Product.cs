using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Product
    {
        public string ID { get; set; }

        public string Nombre { get; set; }

        public string Categoria { get; set; }

        public float Precio { get; set; }
        public int Existencias { get; set; }


        
        public Product(string _id,string _nombre, string _categoria,float _precio,int _exi)
        {
            ID = _id;
            Nombre = _nombre;
            Categoria = _categoria;
            Precio = _precio;
            Existencias = _exi;

        }

    }
}
