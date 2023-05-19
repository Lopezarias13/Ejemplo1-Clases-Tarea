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
        public List<Profesor> listaProfesores = new List<Profesor>();
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
            FrmCentro form = new FrmCentro();
            this.Hide();
            form.ShowDialog();
            this.Show();
            listaCentros.AddRange(form.ListaCentros);
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros listaCentros = new ListaCentros();
            this.Hide();
            listaCentros.Show(this);
            this.Show();
        }
    }
}
