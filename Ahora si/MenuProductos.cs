using Ahora_si.clases;
using Ahora_si.ConexionSql;
using NAudio.Wave;

namespace Ahora_si
{
    public partial class MenuProductos : Form
    {

        private AudioFileReader cadena = new AudioFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sonido.mp3"));
        private WaveOutEvent play = new WaveOutEvent();
        bool pausa = false;
        bool sidebarExpand = false;
        private string cuenta;
        private string contrasena;

        public MenuProductos()
        {
            InitializeComponent();
        }
        public MenuProductos(string cuenta, string contrasena)
        {
            this.cuenta = cuenta;
            this.contrasena = contrasena;
            InitializeComponent();

            play.Init(cadena);
            play.Volume = 0.1f;
            if (!pausa)
            {
                play.PlaybackStopped += reinicio;
                play.Play();

            }

            labelCuenta.Text = cuenta;

            if (cuenta == "invitado")
            {
                button2.Hide();
            }
        }
        private void reinicio(object sender, StoppedEventArgs e)
        {
            if (!pausa)
            {
                cadena.Position = 0;
                play.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (pausa)//si esta puasado
            {
                button3.Text = "Stop Musica";
                play.Play();
                pausa = false;
            }
            else
            {
                button3.Text = "Play Musica";
                play.Stop();
                pausa = true;
            }
        }
        private void MenuProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            play.Stop();
            pausa = true;
        }


        private void MenuProductos_Load(object sender, EventArgs e)
        {
            mostrar();
            EventoPictureBoxes();
            EventoBorrar();
        }

        public void EventoBorrar()
        {
            Button[] butones = { buttonBorrar1, buttonBorrar2, buttonBorrar3, buttonBorrar4, buttonBorrar5, buttonBorrar6, buttonBorrar7, buttonBorrar8, buttonBorrar9, buttonBorrar10 };
            foreach (var but in butones)//va arecorrer todo los botones como se cuales son los que tiene productos?
            {
                but.Click += buttonBorrar_click;
            }
        }

        private void buttonBorrar_click(object? sender, EventArgs e)
        {

            Button? buton = sender as Button;
            if (buton != null)
            {
                Borrar_producto pro= new Borrar_producto(Convert.ToInt32(buton.Tag));
                pro.ShowDialog();
                mostrar();




            }

        }

        public void EventoPictureBoxes()
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            foreach (var pictureBoxe in pictureBoxes)
            {

                pictureBoxe.Click += picturebox_click;

            }

        }

        public void picturebox_click(object? sender, EventArgs e)
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





        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // Si está expandida, contraer
            {
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else // Si está contraída, expandir
            {
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 193)
                {

                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            play.Stop();
        }






        private void labelCuenta_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)//cuenta boton
        {
            Conexion_cuentas aux = new Conexion_cuentas();
            persona edit = aux.Busqueda_Usuario(cuenta, contrasena);
            Editar_cuenta mostrar = new Editar_cuenta(edit);
            mostrar.Show();
        }

        private void buttonFiniquitar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.DialogResult = DialogResult.Abort;
        }



        public void mostrar()
        {
            Conexion_productos con = new Conexion_productos();
            List<producto> pro = con.consulta();

            Button[] butones = { buttonBorrar1, buttonBorrar2, buttonBorrar3, buttonBorrar4, buttonBorrar5, buttonBorrar6, buttonBorrar7, buttonBorrar8, buttonBorrar9, buttonBorrar10 };
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            for (int i = 0; i < pro.Count && i < pictureBoxes.Length && i < labels.Length; i++)
            {

                pictureBoxes[i].Image = Image.FromStream(new MemoryStream(pro[i].Imagen));
                pictureBoxes[i].BackgroundImage = null;
                labels[i].Text = pro[i].Nombre;
                butones[i].Show();

            }

            for (int i=pro.Count; i<10; i++)
            {
                butones[i].Hide();
                labels[i].Text = "";
                pictureBoxes[i].BackgroundImage= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "")
            }

        }
    }
}
