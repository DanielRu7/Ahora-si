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
    public partial class Editar_cuenta : Form
    {
        persona usuario = new persona();


        public Editar_cuenta(persona editar)
        {
            InitializeComponent();
            this.usuario = editar;
        }
        private void Editar_cuenta_Load(object sender, EventArgs e)
        {

            agregar();
        }

        public void agregar()
        {
            textBoxNombre.Text = usuario.Nombre;
            textBoxCuenta.Text = usuario.Cuenta;
            textBoxContrasena.Text = usuario.Contrasena;
        }

        public void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxCuenta.Text == "" || textBoxContrasena.Text == "")
            {
                MessageBox.Show("Datos Faltantes rellena todos los campos");
                agregar();
            }
            else
            {
                usuario.Cuenta = textBoxCuenta.Text;
                usuario.Nombre = textBoxNombre.Text;
                usuario.Contrasena = textBoxContrasena.Text;
                Conexion_cuentas aux = new Conexion_cuentas();
                aux.Editar(usuario);
                this.Close();
            }



        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
