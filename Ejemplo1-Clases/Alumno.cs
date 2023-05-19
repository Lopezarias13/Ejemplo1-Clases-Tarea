using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    //Realizamos la Herencia
    class Alumno:Persona
    {
        //campos
        string exp;
        string tiulacion;
        //Composición, Un estudiante solo puede estar en un centro
        Centro Centro;
        //Agrgamos el constructor vacio
        public Alumno()
        { }

        public Alumno(string exp, string tiulacion)
        {
            this.exp = exp;
            this.tiulacion = tiulacion;
        }

        public string Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }

        public string Tiulacion
        {
            get
            {
                return tiulacion;
            }

            set
            {
                tiulacion = value;
            }
        }
    }
}
