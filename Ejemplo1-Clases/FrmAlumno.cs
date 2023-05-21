using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }
        private void Agregar()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = textBoxNombre.Text;
            alumno.Direccion = textBoxDireccion.Text;
            alumno.Telf = textBoxTelefono.Text;
            alumno.Email = textBoxEmail.Text;
            alumno.Exp = textBoxExpo.Text;
            alumno.Tiulacion = textBoxtiulacion.Text;

            Datos.Alumnos.Add(alumno);
        }
        private void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
            textBoxExpo.Clear();
            textBoxtiulacion.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
