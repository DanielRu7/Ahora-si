using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ahora_si
{
    public partial class ComprarProducto : Form
    {
        producto pro;
        List<producto> productos;

        public ComprarProducto()
        {
            InitializeComponent();
        }
        public ComprarProducto(producto pro,List<producto> productos)
        {
            InitializeComponent();
            this.pro = pro;
            this.productos = productos;
            llenar();
        }
        private void llenar()//carga los datos
        {
            label6.Text = Convert.ToString(pro.Id);
            label7.Text = Convert.ToString(pro.Cantidad);
            label8.Text = pro.Nombre;
            label9.Text = Convert.ToString(pro.Precio);
            label10.Text = pro.Descripcion;
            pictureBoxImagen.Image = Image.FromStream(new MemoryStream(pro.Imagen));

        }


        private void buttonAgregar_Click(object sender, EventArgs e)//compras
        {
            if (pro.Cantidad>Convert.ToInt32( UpDownCan.Text))
            {
                pro.CantidadCompra=(Convert.ToInt32(UpDownCan.Text));
                productos.Add(pro);
                MessageBox.Show($"se Agrego a el carrito de compras {pro.Nombre}, cantidad {pro.CantidadCompra}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad de productos mayor a la existencia");
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
