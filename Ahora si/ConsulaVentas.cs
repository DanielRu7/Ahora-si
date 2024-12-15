using Ahora_si.clases;
using Ahora_si.ConexionSql;
using System.Windows.Forms.DataVisualization.Charting;
namespace Ahora_si
{
    public partial class ConsulaVentas : Form
    {
        List<persona> personas;

        public ConsulaVentas()
        {
            InitializeComponent();
            Conexion_cuentas obj = new Conexion_cuentas();
            this.personas= obj.Consulta();
            labelGanancias.Text=sumar(personas).ToString();
            Graficando();
        }

        private float sumar(List<persona> per)
        {
            float dinero = 0;
            foreach (var p in per)
            {
                dinero += p.Monto;

            }
            return dinero;
        }

        public void Graficando()
        {
            for (int i=1; i<personas.Count; i++)
            {
                Grafica.Series["Ganancias"].Points.AddXY(i,personas[i].Monto);
            }
        }







    }
}
