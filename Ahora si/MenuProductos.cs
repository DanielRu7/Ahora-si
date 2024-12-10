using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;
using System.Media;
using NAudio.Wave;
using Ahora_si.ConexionSql;
using Ahora_si.clases;
using Org.BouncyCastle.Pqc.Crypto.Lms;

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
            play.Volume = 0.5f;
            if (!pausa)
            {
                play.PlaybackStopped += reinicio;
                play.Play();

            }

            labelCuenta.Text = cuenta;

            if (cuenta == "invitado")
            {
                button2.Hide();
                pictureBox13.Hide();
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
                pictureBoxMusica.Image= Properties.Resources.boton_de_pausa;
                button3.Text = "Pausar";
                play.Play();
                pausa = false;
            }
            else
            {
                pictureBoxMusica.Image = Properties.Resources.boton_de_play__1_;
                button3.Text = "Reproducir";
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
        }





        public void EventoPictureBoxes()
        {
            int i = 0;
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            foreach (var pictureBoxe in pictureBoxes)
            {

                pictureBoxe.Click += picturebox_click;
                pictureBoxe.Tag = i;
                i++;
            }

        }

        public void picturebox_click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
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
                    Editar_Producto obj = new Editar_Producto((int)box.Tag);
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
                if (panelSidebar.Width >= 170)
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

            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            for (int i = 0; i < pro.Count && i < pictureBoxes.Length && i < labels.Length; i++)
            {

                pictureBoxes[i].Image = Image.FromStream(new MemoryStream(pro[i].Imagen));
                pictureBoxes[i].BackgroundImage = null;
                labels[i].Text = pro[i].Nombre;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBoxMenu_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarProducto obj = new EliminarProducto();
            obj.Show();
            mostrar();

        }
    }
}
