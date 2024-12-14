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

    public partial class Carrito : Form
    {
        private string cuenta, contrasena;
        Conexion_productos obj = new Conexion_productos();
        private List<producto> carrito = new List<producto>();
        public Carrito(string cuenta,string contrasena)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.contrasena = contrasena;
            Conexion_productos obj = new Conexion_productos();
            carrito = obj.getCarrito();
            llenar();
        }

        public void llenar()
        {

            richTextBoxCarrito.Clear();

            foreach (var pro in carrito)
            {
                string productoInfo = $"ID: {pro.Id}\n" +
                                      $"Nombre: {pro.Nombre}\n" +
                                      $"Precio: {pro.Precio:C}\n" +
                                      $"Cantidad: {pro.Cantidad}\n" +
                                      $"Descripción: {pro.Descripcion}\n" +
                                      "------------------------\n";
                richTextBoxCarrito.AppendText(productoInfo);
            }

            if (carrito.Count == 0)
            {
                richTextBoxCarrito.AppendText("El carrito está vacío.");
            }
        }

        private void buttonVaciar_Click(object sender, EventArgs e)
        {
            Conexion_cuentas conexion_Cuentas = new Conexion_cuentas();
            conexion_Cuentas.actualizarMonto(0, cuenta, contrasena);
            Conexion_productos obj2 = new Conexion_productos();
            obj.vaciarCarroDeCompras(carrito);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
