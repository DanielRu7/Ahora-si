using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System.Windows.Forms;

namespace Ahora_si
{

    public partial class Carrito : Form
    {
        private persona comprador;
        public List<producto> compra;

        float precio;
        public Carrito(persona comprador, List<producto> compra)
        {


            InitializeComponent();
            this.comprador = comprador;
            this.compra = compra;
            llenar();
            calcularPrecio();
            labelMonto.Text=this.precio.ToString();
        }



        public void calcularPrecio()
        {
            foreach (var p in compra)
            {
                this.precio += p.Precio * p.CantidadCompra;
            }
        }




        public void llenar()
        {
            dataGridViewCompra.Rows.Clear();
            dataGridViewCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //datos de data greed
            for (int i = 0; i < compra.Count; i++)
            {
                dataGridViewCompra.RowTemplate.Height = 50;
                dataGridViewCompra.Rows.Add(
                    compra[i].Id,
                    compra[i].Nombre,
                    compra[i].CantidadCompra,
                    compra[i].Precio,
                    Image.FromStream(new MemoryStream(compra[i].Imagen))
                    );
            }
            dataGridViewCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void buttonVaciar_Click(object sender, EventArgs e)
        {
            
            clear();
            compra.Clear();
            llenar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (compra.Count==0)
            {
                MessageBox.Show("No hay productos en tu carrito");
                return;
            }

            
            MessageBox.Show($"Compra realizada con total de :{this.precio}");
            ReciboCompra comp = new ReciboCompra(compra, comprador,this.precio);
            comp.ShowDialog();
            //actualizar el monto en la base de datos mostrar pdf




            foreach (var can in compra)
            {
                can.Cantidad -= can.CantidadCompra;
            }
            Conexion_productos conex = new Conexion_productos();
            conex.ActLotes(compra);
            Conexion_cuentas cone= new Conexion_cuentas();
            comprador.Monto += this.precio;
            cone.actualizarMonto(comprador.Monto,comprador);

            compra.Clear();
            this.Close();
        }

        private void buttonBorrarPro_Click(object sender, EventArgs e)
        {
            if (labelMid.Text == "")
            {
                MessageBox.Show("No hay nada que borrar");
            }
            else
            {
                var productoAEliminar = compra.FirstOrDefault(p => p.Id == Convert.ToInt32(labelMid.Text));
                if (productoAEliminar != null)
                {
                    compra.Remove(productoAEliminar);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }

                clear();
                llenar();
            }
        }




        public void clear()
        {
            dataGridViewCompra.CurrentCell = null;
            labelMid.Text = "";
            labelMnombre.Text = "";
            labelMprecio.Text = "";
            labelMcantidad.Text = "";
            pictureBoxImagen.Image = null;
        }

        private void dataGridViewCompra_SelectionChanged(object sender, EventArgs e)
        {
            labelMid.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Id"].Value);
            labelMnombre.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Nombre"].Value);
            labelMcantidad.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["CantidadCompra"].Value);
            labelMprecio.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Precio"].Value);
            pictureBoxImagen.Image = (Image)dataGridViewCompra.CurrentRow.Cells["Imagen"].Value;

        }
    }
}
