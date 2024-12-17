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
    public partial class ProductosOrdenados : Form
    {
        List<producto> productos;
        public ProductosOrdenados()
        {
            InitializeComponent();

            Conexion_productos conexion = new Conexion_productos();
            this.productos = conexion.consulta();
            ordenar();
            agregar();
        }



        private void ordenar()
        {
            this.productos = productos.OrderByDescending(p => p.Cantidad).ToList();


        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int seleccion = dataGridView1.CurrentRow.Index;
            producto aux = productos[seleccion];
            labelMid.Text = aux.Id.ToString();
            labelMnombre.Text = aux.Nombre.ToString();
            labelMprecio.Text = aux.Precio.ToString();
            labelMcantidad.Text = aux.Cantidad.ToString();
            labelMdescripcion.Text = aux.Descripcion.ToString();
            pictureBoxImagen.Image = Image.FromStream(new MemoryStream(aux.Imagen));

        }


        private void agregar()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < productos.Count; i++)
            {
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Rows.Add(
                    productos[i].Id,
                    productos[i].Nombre,
                    productos[i].Precio,
                    productos[i].Cantidad,
                    Image.FromStream(new MemoryStream(productos[i].Imagen))
                    );
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
