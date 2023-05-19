using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    class Persona
    {
        //campos
        string id;
        string nombre;
        string direccion;
        string telf;
        string email;

        //Constructor vacio y se puede omitir
        public Persona()
        { }

        public Persona(string id, string nombre)
        {
            this.Id = id;
            this.Nombre = Nombre;
        }
        //Propiedades
        public string Id { get { return this.id; } set { this.id = value; } }
       public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
       public string Direccion { get { return this.direccion; } set { this.direccion = value; } }
       public string Telf { get { return this.telf; } set { this.telf = value; } }
       public string Email { get { return this.email; } set { this.email = value; } }
    }
}
