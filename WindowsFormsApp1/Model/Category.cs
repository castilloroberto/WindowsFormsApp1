using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        //constructor
        public Category(int _id,string _nombre,bool _estado)
        {
            ID = _id;
            Nombre = _nombre;
            Estado = _estado;
        }



    }

}
