﻿using System;
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

namespace Ahora_si
{
    public partial class MenuProductos : Form
    {

        private AudioFileReader cadena = new AudioFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sonido.wav"));
        private WaveOutEvent play = new WaveOutEvent();
        bool pausa = true;

        bool sidebarExpand = false;
        public MenuProductos()
        {
            InitializeComponent();
        }
        public MenuProductos(string cuenta, string contrasena)
        {

            InitializeComponent();

            play.Init(cadena);
            play.Volume = 0.2f;
            if (!pausa)
            {
                play.PlaybackStopped += reinicio;
            }

            play.Play();

            labelCuenta.Text = cuenta;
        }

        private void reinicio(object sender, StoppedEventArgs e)
        {
            cadena.Position = 0;
            play.Play();
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

        private void button3_Click(object sender, EventArgs e)
        {

            if (pausa)//si esta puasado
            {
                button3.Text = "Play Musica";
                play.Stop();
                pausa = false;
            }
            else
            {
                button3.Text = "Parar Musica";
                play.Play();
                pausa = true;
            }
        }

        private void MenuProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            play.Stop();
        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
