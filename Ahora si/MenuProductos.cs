using Ahora_si.clases;
using Ahora_si.ConexionSql;
using NAudio.Wave;

namespace Ahora_si
{
    public partial class MenuProductos : ClaseBase
    {

        private Button[] borrar;
        private Label[] Existencia;
        public MenuProductos()
        {
            InitializeComponent();
        }
        public MenuProductos(string cuenta, string contrasena)
        {
            Datos(cuenta, contrasena);

            InitializeComponent();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            Button[] botones = { button1, button2, button3, buttonFiniquitar };

            Button[] borrar = { buttonBorrar1, buttonBorrar2, buttonBorrar3, buttonBorrar4, buttonBorrar5, buttonBorrar6, buttonBorrar7, buttonBorrar8, buttonBorrar9, buttonBorrar10 };
            this.borrar = borrar;
            Label[] Existencia = { labelNoE1, labelNoE2, labelNoE3, labelNoE4, labelNoE5, labelNoE6, labelNoE7, labelNoE8, labelNoE9, labelNoE10 };
            this.Existencia = Existencia;
            obtener(labels, pictureBoxes, botones, panelSidebar, sidebarTransition, pictureBoxMenu,labelCuenta);

        }


        private void MenuProductos_FormClosing(object sender, FormClosingEventArgs e)//general
        {
            cerrar();
        }


        private void MenuProductos_Load(object sender, EventArgs e)
        {
            mostrar();
            EventoPictureBoxes();
            EventoBorrar();
        }

        public void EventoBorrar()
        {
            int i = 0;
            foreach (var but in borrar)
            {
                but.Click += buttonBorrar_click;
                but.Tag = i;
                i++;
            }
        }

        private void buttonBorrar_click(object? sender, EventArgs e)
        {

            Button? buton = sender as Button;
            if (buton != null)
            {
                Borrar_producto pro = new Borrar_producto(Convert.ToInt32(buton.Tag));
                pro.ShowDialog();
                mostrar();
            }

        }



        public override void picturebox_click(object? sender, EventArgs e)
        {
            PictureBox? box = sender as PictureBox;
            if (box != null)
            {
                if (box.Image == null)
                {
                    AgregarProducto obj = new AgregarProducto();
                    obj.ShowDialog();
                    mostrar();
                }
                else
                {
                    Editar_Producto obj = new Editar_Producto(Convert.ToInt32(box.Tag));
                    obj.ShowDialog();
                    mostrar();
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
                else
                {
                    Existencia[i].Text = "";
                }

                if (pro.Count<=6)
                {
                    borrar[i].Hide();
                }
                else
                {
                    borrar[i].Show();
                }

                productos[i].Image = Image.FromStream(new MemoryStream(pro[i].Imagen));
                productos[i].BackgroundImage = null;
                nombres[i].Text = pro[i].Nombre;
                

            }

            for (int i = pro.Count; i < 10; i++)
            {
                borrar[i].Hide();
                nombres[i].Text = "";
                productos[i].Image = null;
                productos[i].BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "botonagregar-removebg-preview.png"));
            }

        }

        private void timerparpadea_Tick(object sender, EventArgs e)
        {
            label12.Visible = !label12.Visible;
            label11.Visible = !label11.Visible;
        }

        private void buttonOrden_Click(object sender, EventArgs e)
        {
            ProductosOrdenados obj = new ProductosOrdenados();
            obj.ShowDialog();

        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            ConsulaVentas obj = new ConsulaVentas();
            obj.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}