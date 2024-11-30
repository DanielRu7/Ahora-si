using Ahora_si.ConexionSql;
using System.Collections.Specialized;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;
using System.IO;
using System.Windows.Forms.PropertyGridInternal;
using NAudio.Wave;
namespace Ahora_si


{
    public partial class Crear_cuenta : Form
    {
        
        public Crear_cuenta()
        {
            InitializeComponent();
            ActiveControl = label1;
            
            

        }
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre, cuenta, contrasena;
            nombre = textBoxNombre.Text;
            cuenta = textBoxCuenta.Text;
            contrasena = textBoxContrasena.Text;
            if (nombre == "" || cuenta == "" || contrasena == "")
            {
                MessageBox.Show("LLena todos los campos!");
                return;
            }
            Conexion_cuentas con = new Conexion_cuentas();
            con.Insertar(nombre, cuenta, contrasena);
            limpiarCampos();
            SignUp.Hide();
            LogIn.Show();


        }

        void limpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxCuenta.Clear();
            textBoxContrasena.Clear();
            textBoxContrasena1.Clear();
            textBoxCuenta1.Clear();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            MenuProductos nuevo = new MenuProductos();
            nuevo.Show();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn.Hide();
            SignUp.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp.Hide();
            LogIn.Show();
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            string cuenta, contrasena;
            bool res;
            cuenta = textBoxCuenta1.Text;
            contrasena = textBoxContrasena1.Text;
            if (cuenta == "" || cuenta == "")
            {
                MessageBox.Show("Llena todos los datos");
                return;
            }
            Conexion_cuentas con = new Conexion_cuentas();
            if (con.Buscar(cuenta, contrasena))
            {

                MenuProductos obj = new MenuProductos(cuenta, contrasena);
                this.Hide();
                obj.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Error Cuanta o contrasena incorrecta");
            }
            limpiarCampos();
            con.cerrar();



        }
    }
}
