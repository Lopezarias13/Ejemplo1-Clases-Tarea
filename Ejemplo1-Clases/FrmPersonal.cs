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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
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
            Personal personal = new Personal();
            personal.Nombre = textBoxNombre.Text;
            personal.Direccion = textBoxDireccion.Text;
            personal.Email = textBoxEmail.Text;
            personal.Telf = textBoxTelefono.Text;
            personal.Unidad = textBoxUnidad.Text;
            personal.Categoria = textBoxCategoria.Text;
            Datos.Personanles.Add(personal);
        }
        private void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxEmail.Clear();
            textBoxTelefono.Clear();
            textBoxUnidad.Clear();
            textBoxCategoria.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
