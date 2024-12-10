﻿using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahora_si
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxId.Text == "" || richTextBoxDescripcion.Text == "" || textBoxNombre.Text == "" || textBoxCantidad.Text == "" || textBoxPrecio.Text == "" || pictureBoxImagen.Image == null)
            {
                MessageBox.Show("Llena todos los campos");
                return;
            }
            producto obj = new producto();
            obj.Id = Convert.ToInt32(textBoxId.Text);
            obj.Nombre = Convert.ToString(textBoxNombre.Text);
            obj.Precio = Convert.ToSingle(textBoxPrecio.Text);
            obj.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
            obj.Descripcion = Convert.ToString(richTextBoxDescripcion.Text);
            ImagenConvert aux = new ImagenConvert();
            obj.Imagen = aux.imagenToByte(pictureBoxImagen.Image);


            Conexion_productos conexion = new Conexion_productos();
            if (conexion.insertar(obj))
            {
                this.Close();
            }


        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagen.ImageLocation = ofd.FileName;
                pictureBoxImagen.BackgroundImage = null;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
