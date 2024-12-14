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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ahora_si
{

    public partial class Carrito : Form
    {
        private persona comprador;
        public List<producto> compra;
        private producto borrarPro;

        public Carrito(persona comprador, List<producto> compra)
        {


            InitializeComponent();
            this.comprador = comprador;
            this.compra = compra;
            llenar();
        }

        public void llenar()
        {
            //datos de data greed
            for (int i=0; i< compra.Count; i++)
            {
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


            compra.Clear();
            this.Close();
        }

        private void buttonBorrarPro_Click(object sender, EventArgs e)
        {
            if (labelMid.Text=="")
            {
                MessageBox.Show("No hay nada que borrar");
            }
            else
            {
                compra.Remove(borrarPro);
                clear();
                llenar();
            }
        }

        public void clear()
        {
            labelMid.Text = "";
            labelMnombre.Text = "";
            labelMprecio.Text = "";
            labelMdescripcion.Text = "";
            labelMcantidad.Text = "";
        }




    }
}
