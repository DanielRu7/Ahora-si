using Ahora_si.ConexionSql;
using System.Collections.Specialized;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;
using System.IO;
using System.Windows.Forms.PropertyGridInternal;
using NAudio.Wave;
using Ahora_si.clases;
namespace Ahora_si


{
    public partial class Crear_cuenta : Form
    {

        public Crear_cuenta()
        {
            InitializeComponent();
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
            ButtonInvitado.Show();


        }

        void limpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxCuenta.Clear();
            textBoxContrasena.Clear();
            textBoxContrasena1.Clear();
            textBoxCuenta1.Clear();
        }


        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonInvitado.Hide();
            SignUp.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp.Hide();
            ButtonInvitado.Show();
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
                Conexion_cuentas doble = new Conexion_cuentas();

                persona per = doble.Busqueda_Usuario(cuenta, contrasena);
                if (per.Admin == true)
                {
                    MenuProductos obj = new MenuProductos(cuenta, contrasena);
                    this.Hide();
                    if (obj.ShowDialog() != DialogResult.Abort)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    MenuProductos2 obj = new MenuProductos2(cuenta, contrasena);
                    this.Hide();
                    if (obj.ShowDialog() != DialogResult.Abort)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("Error Cuanta o contrasena incorrecta");
            }
            limpiarCampos();
            con.cerrar();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuProductos2 obj = new MenuProductos2("invitado", "invitado");
            this.Hide();
            if (obj.ShowDialog() != DialogResult.Abort)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void SignUp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
