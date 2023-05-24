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
    public partial class ListaCentros : Form
    {
        public ListaCentros()
        {
            InitializeComponent();
        }

        private void ListaCentros_Load(object sender, EventArgs e)
        {
            List<Centro> listaCentros = ((Form1)Owner).listaCentros;


            dataGridView1.DataSource = listaCentros;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
