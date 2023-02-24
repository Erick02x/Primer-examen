using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickDelCid
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segundo_Formulario Segundo_Formulario = new Segundo_Formulario();
            Segundo_Formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tercer_Formulario Tercer_Formulario = new Tercer_Formulario();
            Tercer_Formulario.Show();
        }
    }
}
