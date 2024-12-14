using Ahora_si.clases;
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
    public partial class Editar_Producto : Form
    {
        private producto pro;
        private int indice;
        public Editar_Producto()
        {
            InitializeComponent();
            llenar();
        }
        public Editar_Producto(int indice)
        {
            InitializeComponent();
            this.indice = indice;
            llenar();
        }


        private void llenar()
        {
            Conexion_productos con = new Conexion_productos();
            pro = con.BuscarNombre(indice);
            textBoxId.Text = Convert.ToString(pro.Id);
            textBoxCantidad.Text = Convert.ToString(pro.Cantidad);
            textBoxNombre.Text = pro.Nombre;
            textBoxPrecio.Text = Convert.ToString(pro.Precio);
            richTextBoxDescripcion.Text = pro.Descripcion;
            pictureBoxImagen.Image = Image.FromStream(new MemoryStream(pro.Imagen));

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || richTextBoxDescripcion.Text == "" || textBoxNombre.Text == "" || textBoxCantidad.Text == "" || textBoxPrecio.Text == "")
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
            if (conexion.Actualizar(obj))
            {
                this.Close();
            }

        }

        private void pictureBoxImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagen.ImageLocation = ofd.FileName;
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
