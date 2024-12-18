using Ahora_si.clases;
using Ahora_si.ConexionSql;
using NAudio.Wave;

namespace Ahora_si
{
    public partial class MenuProductos2 : ClaseBase
    {
        private Label[] Existencia;
        private string cuenta, contrasena;
        List<producto> compra = new List<producto>();


        public MenuProductos2()
        {
            InitializeComponent();
        }
        public MenuProductos2(string cuenta, string contrasena)
        {
            this.cuenta = cuenta;
            this.contrasena = contrasena;
            Datos(cuenta, contrasena);

            InitializeComponent();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            Button[] botones = { button1, button2, button3, buttonFiniquitar };

            Label[] Existencia = { labelNoE1, labelNoE2, labelNoE3, labelNoE4, labelNoE5, labelNoE6, labelNoE7, labelNoE8, labelNoE9, labelNoE10 };
            this.Existencia = Existencia;
            obtener(labels, pictureBoxes, botones, panelSidebar, sidebarTransition, pictureBoxMenu, labelCuenta);


            if (cuenta == "invitado")
            {
                button2.Hide();
                pictureBox13.Hide();
            }

        }

        //modificar mostrar
        //quitar los botones y eventos


        private void MenuProductos_FormClosing(object sender, FormClosingEventArgs e)//general
        {

            cerrar();
        }


        private void MenuProductos_Load(object sender, EventArgs e)
        {
            mostrar();
            EventoPictureBoxes();
        }


        public override void picturebox_click(object? sender, EventArgs e)//cambiar
        {
            PictureBox? box = sender as PictureBox;
            if (box != null)
            {
                //FINALY
                Conexion_productos conexion = new Conexion_productos();
                producto pro = conexion.BuscarNombre(Convert.ToInt32(box.Tag));
                if (pro.Cantidad <= 0)
                {
                    MessageBox.Show("NO HAY EXISTENCIAS");
                }
                else
                {
                    //mandar el producto entero
                    ComprarProducto comp = new ComprarProducto(pro, compra);
                    comp.ShowDialog();

                }


            }

        }

        public void mostrar()//LO SOLUCIONA TODO B)
        {
            Conexion_productos con = new Conexion_productos();
            List<producto> pro = con.consulta();

            for (int i = 0; i < pro.Count && i < productos.Length && i < nombres.Length; i++)
            {
                if (pro[i].Cantidad <= 0)
                {
                    Existencia[i].Text = "No Existencia";
                }

                productos[i].Image = Image.FromStream(new MemoryStream(pro[i].Imagen));
                nombres[i].Text = pro[i].Nombre;

            }

            for (int i = pro.Count; i < 10; i++)
            {
                productos[i].Hide();
                nombres[i].Text = "";
            }

        }

        private void pictureBoxCarrito_Click(object sender, EventArgs e)//cambiar
        {
            Conexion_cuentas usu = new Conexion_cuentas();
            persona per = usu.Busqueda_Usuario(cuenta, contrasena);

            Carrito carrito = new Carrito(per, compra);
            carrito.ShowDialog();
            mostrar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToLongTimeString();
            label12.Text = DateTime.Now.ToLongDateString();
        }

        private void labelCuenta_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}