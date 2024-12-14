﻿using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ahora_si
{
    public partial class ComprarProducto : Form
    {
        producto pro;
        private string cuenta, contrasena;

        public ComprarProducto()
        {
            InitializeComponent();
        }
        public ComprarProducto(producto pro,string cuenta,string contrasena)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.contrasena = contrasena;
            this.pro = pro;
            llenar();
        }
        private void llenar()
        {
            textBoxId.Text = Convert.ToString(pro.Id);
            textBoxCantidad.Text = Convert.ToString(pro.Cantidad);
            textBoxNombre.Text = pro.Nombre;
            textBoxPrecio.Text = Convert.ToString(pro.Precio);
            richTextBoxDescripcion.Text = pro.Descripcion;
            pictureBoxImagen.Image = Image.FromStream(new MemoryStream(pro.Imagen));

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Conexion_productos obj2 = new Conexion_productos();

            Conexion_productos obj = new Conexion_productos();
            obj.agregarCarroDeCompras(pro);
            obj.actualizarMonto(obj2.getCarrito(),cuenta, contrasena);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}