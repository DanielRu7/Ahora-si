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

namespace Ahora_si
{
    public partial class Borrar_producto : Form
    {
        int tag;//donde voy a borrar
        producto? borrar;
        public Borrar_producto()
        {
            InitializeComponent();
        }

        public Borrar_producto(int tag)
        {
            InitializeComponent();
            this.tag = tag;
            cargarNombre();
        }

        public void cargarNombre()
        {
            Conexion_productos con= new Conexion_productos();
            producto nombre=borrar= con.BuscarNombre(tag);
            labelProducto.Text = nombre.Nombre;
            
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Conexion_productos conexion = new Conexion_productos();
            conexion.Eliminar(borrar);
            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
