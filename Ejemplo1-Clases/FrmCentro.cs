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
    public partial class FrmCentro : Form
    {
        public List<Centro> ListaCentros = new List<Centro>();
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void AgregarCentro()
        {
            Centro centro = new Centro();
            centro.Nombre = textBoxNombre.Text;
            centro.Dir = textBoxDireccion.Text;
            centro.Telf = textBoxTelefono.Text;
            centro.Email = textBoxEmail.Text;

            ListaCentros.Add(centro);
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCentro();
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
