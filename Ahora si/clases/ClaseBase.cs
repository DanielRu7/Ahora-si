using Ahora_si.ConexionSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ahora_si.clases
{
    public class ClaseBase:Form
    {
        public Label[] nombres;

        public PictureBox[] productos;
        private bool sidebarExpand = false;
        private System.Windows.Forms.Timer sidebarTransition;
        private Musica musica;
        private Panel panelSidebar;

        private string? cuenta;
        private string? contrasena;

        public void Datos(string cuenta,string contrasena)
        {
            this.contrasena = contrasena;
            this.cuenta = cuenta;
        }


        public void obtener(Label[] nombres, PictureBox[] productos, Button[] boton, Panel panelSidebar, System.Windows.Forms.Timer sidebarTransition,PictureBox menu)
        {
            this.panelSidebar = panelSidebar;
            this.nombres = nombres;
            this.productos = productos;
            musica = new Musica(boton[2]);
            boton[0].Click += SalirCuenta_Click;
            this.sidebarTransition = sidebarTransition;
            sidebarTransition.Tick += sidebarTransition_Tick;
            menu.Click += pictureBoxMenu_Click;
            menu.MouseHover += pictureBoxMenu_MouseHover;
            boton[1].Click += button2_Click;
            boton[3].Click += buttonFiniquitar_Click;
            MauseCambio();

        }

        


        public void MauseCambio()
        {
            int i = 0; 
            foreach (var box in productos)
            {
                box.MouseHover += pictureBox1_MouseHover;
                box.MouseLeave += pictureBox1_MouseLeave;
                box.Tag = i;
                i++;

            }


        }


        private void SalirCuenta_Click(object? sender, EventArgs e)//MUSICA
        {
            this.Close();
            musica.play.Stop();
        }
        public void cerrar()//CUANDO SE CIERRA El FORMS //MUSICA
        {
            musica.play.Stop();
            musica.pausa = true;
        }

        public virtual void cargar()
        {

        }//TRES COSAS

        public void sidebarTransition_Tick(object? sender, EventArgs e)
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


        private void pictureBoxMenu_Click(object? sender, EventArgs e)
        {
            sidebarTransition.Start();
        }


        private void button2_Click(object? sender, EventArgs e)//cuenta boton
        {
            Conexion_cuentas aux = new Conexion_cuentas();
            persona edit = aux.Busqueda_Usuario(cuenta ?? "", contrasena ?? "");
            Editar_cuenta mostrar = new Editar_cuenta(edit);
            mostrar.Show();
        }

        private void buttonFiniquitar_Click(object? sender, EventArgs e)
        {
            Application.Exit();
            this.DialogResult = DialogResult.Abort;
        }





        private void pictureBox1_MouseHover(object? sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object? sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void pictureBoxMenu_MouseHover(object? sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        public void EventoPictureBoxes()
        {

            foreach (var pictureBoxe in productos)
            {

                pictureBoxe.Click += picturebox_click;

            }

        }

        public virtual void picturebox_click(object? sender, EventArgs e)
        {

        }


    }
}
