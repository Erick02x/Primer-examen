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
    public partial class Segundo_Formulario : Form
    {
        public Segundo_Formulario()
        {
            InitializeComponent();
        }
       
        private async void CalcularButton_Click(object sender, EventArgs e)
        {
          
                string producto = ProdutoTextBox.Text;
                double precio = Convert.ToDouble(PrecioTextBox.Text);
                double cantidad = Convert.ToDouble(CantidadTextBox.Text);
                double total = await CalcularAsync(precio, cantidad);
           
                MessageBox.Show($"El producto comprado es: {producto} con un costo de: {total}");
            
        }
        private async Task<double> CalcularAsync(double p1, double cant)
        {
           
            double total = await Task.Run(() =>
            {
                return (p1*cant)*-0.15+(p1*cant);
            });
            return total;
        }
    }
}
