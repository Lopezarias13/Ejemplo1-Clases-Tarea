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
    public partial class Form1 : Form
    {
        public List<Centro> listaCentros = new List<Centro>();
        //public List<Profesor> listaProfesores = new List<Profesor>();
        public List<Alumno> listaAlumnos = new List<Alumno>();
        public List<Personal> listaPersonales = new List<Personal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarCentro();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros listaCentros = new ListaCentros();
            this.Hide();
            listaCentros.Show(this);
            this.Show();
        }
        private void AgregarCentro()
        {
            FrmCentro form = new FrmCentro();
            this.Hide();
            form.ShowDialog();
            this.Show();
            //Datos.Centros.AddRange(form.ListaCentros);
            listaCentros.AddRange(form.ListaCentros);
        }
        
        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores listProfesores = new ListaProfesores();
            this.Hide();
            listProfesores.Show(this);
            this.Show();

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor profesor = new FrmProfesor();
            this.Hide();
            profesor.ShowDialog();
            this.Show();
            
        }
    }
}
