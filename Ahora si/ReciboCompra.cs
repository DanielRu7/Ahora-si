using Ahora_si.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahora_si
{
    public partial class ReciboCompra : Form
    {
        private List<producto> productos;
        private float precio;

        public ReciboCompra()
        {
            InitializeComponent();
        }
        public ReciboCompra(List<producto> productos, persona person,float precio)
        {
            InitializeComponent();
            this.productos = productos;
            labelFecha.Text = DateTime.Now.ToString();
            textBoxRecibo.Enabled = false;
            this.precio = precio;
            labelPersona.Text = $"Comp.:{person.Nombre} Cuent.:{person.Cuenta}";
            llenar();
            
        }


        private void llenar()
        {
            textBoxRecibo.Text = $"ID".PadRight(12) + "Nombre".PadRight(25) + "Precio".PadRight(15) + "Cantidad\n";
            foreach (producto pro in productos)
            {
                textBoxRecibo.Text += $"{pro.Id.ToString().PadRight(12)}" +
                                      $"{pro.Nombre.PadRight(25)}" +
                                      $"{pro.Precio.ToString().PadRight(15)}" +
                                      $"{pro.CantidadCompra.ToString().PadRight(10)}\n";
            }

            textBoxRecibo.Text += $"Subtotal: {Math.Round(this.precio/1.16,2)}\n";
            textBoxRecibo.Text += $"IVA: {Math.Round(this.precio/1.16*.16,2)}\n";
            textBoxRecibo.Text += $"TOTAL: {Math.Round(this.precio,2)} \n";


        }




        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
