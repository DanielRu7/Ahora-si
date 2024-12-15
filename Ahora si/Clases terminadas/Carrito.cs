using Ahora_si.clases;
using Ahora_si.ConexionSql;

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
            //actualizar el monto en la base de datos mostrar pdf
           


            
            if (compra.Count==0)
            {
                MessageBox.Show("No hay productos en tu carrito");
                return;
            }



            foreach (var can in compra)
            {
                can.Cantidad -= can.CantidadCompra;
            }
            Conexion_productos conex = new Conexion_productos();
            conex.ActLotes(compra);
            Conexion_cuentas cone= new Conexion_cuentas();
            comprador.Monto += this.precio;
            cone.actualizarMonto(comprador.Monto,comprador);
            MessageBox.Show($"Compra realizada con total de :{this.precio}");
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
            int seleccion = dataGridViewCompra.CurrentRow.Index;
            if (compra.Count!=0)
            {
                producto pro = compra[seleccion];
                labelMid.Text = pro.Id.ToString();
                labelMnombre.Text = pro.Nombre.ToString();
                labelMprecio.Text = pro.Precio.ToString();
                labelMcantidad.Text = pro.Cantidad.ToString();
                pictureBoxImagen.Image = Image.FromStream(new MemoryStream(pro.Imagen));
            }
            
        }
    }
}
