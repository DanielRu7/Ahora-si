using MySql.Data.MySqlClient;

namespace Ahora_si.ConexionSql
{
    public class Conexion_cuentas
    {
        static string Cadena = "Server=localhost; Database=personal; User=root; Password=; SslMode=none;";//este es el server es static para que lo puedan llamar por fuera
        static MySqlConnection conexion;//la conexion

        public Conexion_cuentas()
        {
            conect();
        }


        public void conect()
        {

            try
            {
                conexion = new MySqlConnection(Cadena);
                conexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error conexion a el server");
            }
        }

        public void cerrar()
        {
            if (conexion!=null && conexion.State== System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }


        public void Insertar(string nombre,string cuenta,string contrasena)//conexion a la base de datos persona agrega cuentas OJO
        {
            
            try
            {
                string query = "INSERT INTO persona (nombre, cuenta, contrasena) VALUES ('" + nombre + "','" + cuenta + "','" + contrasena + "')";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta");
            }
            cerrar();
        }

        public bool Buscar(string cuenta, string contrasena)
        {
            try
            {
                string query = "SELECT * FROM persona WHERE cuenta='" + cuenta + "' AND contrasena='"+contrasena+"';";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar la cuenta");
                return false;
            }
        }

    }
}
