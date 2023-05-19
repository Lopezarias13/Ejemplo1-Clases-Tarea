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

    public partial class FrmProfesor : Form
    {
        public List<Profesor> listaProfesores = new List<Profesor>();
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCentro();
            LimpiarCampos();
        }
        private void AgregarCentro()
        {
            //Agregar 
            Profesor profesor = new Profesor();
            profesor.Nombre = textBoxNombre.Text;
            profesor.Direccion = textBoxDireccion.Text;
            profesor.Telf = textBoxTelefono.Text;
            profesor.Email = textBoxEmail.Text;
            profesor.INSS = textBoxINSS.Text;
            profesor.Salario = double.Parse(textBoxSalario.Text);

            listaProfesores.Add(profesor);
        }
        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
            textBoxINSS.Clear();
            textBoxSalario.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
