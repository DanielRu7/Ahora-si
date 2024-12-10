using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahora_si.clases
{
    public class Musica    //VA A ADMIN Y VENTA DE PRODUCTOS
    {
        //SON DEL AUDIO
        private AudioFileReader cadena = new AudioFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sonido.mp3"));
        public WaveOutEvent play = new WaveOutEvent();
        public bool pausa = false;

        private Button boton;


        public Musica(Button boton)
        {
            this.boton = boton;
            boton.Click += button3_Click;
            Inicio();
        }

        public void Inicio()
        {
            play.Init(cadena);
            play.Volume = 0.1f;
            if (!pausa)
            {
                play.PlaybackStopped += reinicio;
                play.Play();

            }

        }
        private void reinicio(object? sender, StoppedEventArgs e)
        {
            if (!pausa)
            {
                cadena.Position = 0;
                play.Play();
            }
        }

        private void button3_Click(object? sender, EventArgs e)
        {

            if (pausa)//si esta puasado
            {
                boton.Text = "Stop Musica";
                play.Play();
                pausa = false;
            }
            else
            {
                boton.Text = "Play Musica";
                play.Stop();
                pausa = true;
            }
        }



    }
}
