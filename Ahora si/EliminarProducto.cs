using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Ahora_si
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxIdEliminar.Text == "")
            {
                MessageBox.Show("Ingresa el ID del producto a eliminar.");
                return;
            }

            int id = Convert.ToInt32(textBoxIdEliminar.Text);
            Conexion_productos conexion = new Conexion_productos();
            if (conexion.Eliminar(id))
            {
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
