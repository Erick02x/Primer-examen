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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

             
        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            double resultado = Ejecutar();
            ResultadoLabel.Text = Convert.ToString(resultado);

        }
         private double Ejecutar(double capital=200000)
        {
            string operacion = OperacionesComboBox.Text;
            double resultado = 0;           

            if (operacion == "Enero")
            {
                resultado = (capital * 0.015);
            }
            else if (operacion == "Febrero")
            {
                resultado = (capital * 0.015)* 2;
            }
            else if (operacion == "Marzo")
            {
                resultado = (capital * 0.015) * 3;
            }
            else if (operacion == "Abril")
            {
                resultado = (capital * 0.015) * 4;
            }
            else if (operacion == "Mayo")
            {
                resultado = (capital * 0.015) * 5;
            }
            else if (operacion == "Junio")
            {
                resultado = (capital * 0.015) * 6;
            }
            else if (operacion == "Julio")
            {
                resultado = (capital * 0.015) * 7;
            }
            else if (operacion == "Agosto")
            {
                resultado = (capital * 0.015) * 8;
            }
            else if (operacion == "Septiembre")
            {
                resultado = (capital * 0.015) * 9;
            }
            else if (operacion == "Octubre")
            {
                resultado = (capital * 0.015) * 10;
            }
            else if (operacion == "Noviembre")
            {
                resultado = (capital * 0.015) * 11;
            }
            else if (operacion == "Diciembre")
            {
                resultado = (capital * 0.015) * 12;
            }


            return resultado;

        }

    }
}
