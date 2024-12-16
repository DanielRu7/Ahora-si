using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;

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
            labelMonto.Text = this.precio.ToString("C");
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

            for (int i = 0; i < compra.Count; i++)
            {
                dataGridViewCompra.RowTemplate.Height = 50;

                // Convertir byte[] a Image si es necesario
                System.Drawing.Image imagenProducto = null;
                if (compra[i].Imagen != null && compra[i].Imagen.Length > 0)
                {
                    using (var ms = new MemoryStream(compra[i].Imagen))
                    {
                        imagenProducto = System.Drawing.Image.FromStream(ms);
                    }
                }

                dataGridViewCompra.Rows.Add(
                    compra[i].Id,
                    compra[i].Nombre,
                    compra[i].CantidadCompra,
                    compra[i].Precio,
                    imagenProducto
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
            if (compra.Count == 0)
            {
                MessageBox.Show("No hay productos en tu carrito");
                return;
            }

            MessageBox.Show($"Compra realizada con total de: {this.precio:.}");
            ReciboCompra comp = new ReciboCompra(compra, comprador, this.precio);
            comp.ShowDialog();

            // Obtener la ruta dinámica al escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "reciboCompra.pdf");

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.LETTER, 20, 20, 30, 30);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();
                doc.AddAuthor("Candy Shop");
                doc.AddTitle("Recibo de compra");

                // Agregar imagen centrada
                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.Alignment = Element.ALIGN_CENTER;
                    logo.ScaleToFit(100f, 100f);
                    doc.Add(logo);
                }

                // Agregar encabezado "Candy Shop"
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                Paragraph header = new Paragraph("Candy Shop", headerFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(header);
                doc.Add(new Paragraph("Sabores que iluminan la Pantalla", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC, BaseColor.GRAY)) { Alignment = Element.ALIGN_CENTER });
                doc.Add(Chunk.NEWLINE);


                // Agregar fecha y hora de la compra
                iTextSharp.text.Font dateFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);
                Paragraph date = new Paragraph($"Fecha y hora: {DateTime.Now}", dateFont) { Alignment = Element.ALIGN_RIGHT };
                doc.Add(date);
                doc.Add(Chunk.NEWLINE);

                // Tabla con los productos
                PdfPTable tblProductos = new PdfPTable(3) { WidthPercentage = 100 };
                tblProductos.AddCell(new PdfPCell(new Phrase("Cantidad")) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = BaseColor.LIGHT_GRAY });
                tblProductos.AddCell(new PdfPCell(new Phrase("Nombre")) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = BaseColor.LIGHT_GRAY });
                tblProductos.AddCell(new PdfPCell(new Phrase("Precio")) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = BaseColor.LIGHT_GRAY });

                int totalArticulos = 0;
                foreach (var producto in compra)
                {
                    tblProductos.AddCell(new PdfPCell(new Phrase(producto.CantidadCompra.ToString())) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tblProductos.AddCell(new PdfPCell(new Phrase(producto.Nombre)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tblProductos.AddCell(new PdfPCell(new Phrase(producto.Precio.ToString("."))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    totalArticulos += producto.CantidadCompra;
                }
                doc.Add(tblProductos);

                doc.Add(Chunk.NEWLINE);

                // Calcular y mostrar el IVA y total con IVA
                float iva = 0.16f;
                float precioConIVA = this.precio * (1 + iva);
                Paragraph precioIVA = new Paragraph($"Total (IVA incluido 16%): {precioConIVA:C}", headerFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(precioIVA);

                // Mostrar total de artículos
                Paragraph totalArt = new Paragraph($"Total de artículos: {totalArticulos}", headerFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(totalArt);

                doc.Add(Chunk.NEWLINE);

                // Agregar mensaje de agradecimiento
                iTextSharp.text.Font footerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                Paragraph footer = new Paragraph("Gracias por su compra, ojala no vuelva", footerFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(footer);

                doc.Close();
            }

            // Actualizar la base de datos
            foreach (var can in compra)
            {
                can.Cantidad -= can.CantidadCompra;
            }

            Conexion_productos conex = new Conexion_productos();
            conex.ActLotes(compra);

            Conexion_cuentas cone = new Conexion_cuentas();
            comprador.Monto += this.precio;
            cone.actualizarMonto(comprador.Monto, comprador);

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
            if (dataGridViewCompra.CurrentRow != null)
            {
                labelMid.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Id"].Value);
                labelMnombre.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Nombre"].Value);
                labelMcantidad.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["CantidadCompra"].Value);
                labelMprecio.Text = Convert.ToString(dataGridViewCompra.CurrentRow.Cells["Precio"].Value);

                var imagenCelda = dataGridViewCompra.CurrentRow.Cells["Imagen"].Value;
                if (imagenCelda is byte[] imagenBytes)
                {
                    using (var ms = new MemoryStream(imagenBytes))
                    {
                        pictureBoxImagen.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else if (imagenCelda is System.Drawing.Image imagen)
                {
                    pictureBoxImagen.Image = imagen;
                }
                else
                {
                    pictureBoxImagen.Image = null; // Si no es imagen válida
                }
            }
        }

    }
}
