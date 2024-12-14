using System;
using System.Windows.Forms;

namespace Ahora_si
{
    public partial class segundaportada : Form
    {


        public segundaportada()
        {
            InitializeComponent();
            timer1.Start(); // Inicia el Timer
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Alternar la visibilidad del Label
            //label1.Visible = !label1.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_cuenta cosa = new Crear_cuenta();
            cosa.ShowDialog();
        }
    }
}
