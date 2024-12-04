using Ahora_si.clases;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ahora_si.ConexionSql
{
    internal class Conexion_productos
    {

        private string Cadena = "Server=localhost; Database=personal; User=root; Password=; SslMode=none;";
        private MySqlConnection conexion;

        public Conexion_productos()
        {
            conect();
        }

        private void conect()
        {
            try
            {
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("Fallo conexion productos");
            }
        }
        public void cerrar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        
        public void insertar(producto add)
        {
            try
            {
                string query = "INSERT INTO productos (id, nombre, precio, cantidad,imagen,descripcion) VALUES (" + add.Id + ",'" + add.Nombre + "'," + add.Precio + ","+add.Cantidad+","+add.Imagen+","+add.Descripcion+")";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta en el server");
            }
            cerrar();

        }

        public List<producto> consulta()
        {
            List<producto> lista = new List<producto>();
            string query = "SELECT * FROM producto";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto pro = new producto();
                    pro.Id = Convert.ToInt32(reader["id"]);
                    pro.Nombre = Convert.ToString(reader["nombre"])??"";
                }

                
            }
            catch
            {
                MessageBox.Show("Error al mostrar");
            }

            return lista;
        }



    }
}
