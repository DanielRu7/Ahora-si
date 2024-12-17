using Ahora_si.clases;
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
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public void actualizarMonto(float monto, persona pers)
        {
            try
            {

                string query = "UPDATE persona SET monto = @monto WHERE cuenta = @cuenta AND contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@cuenta", pers.Cuenta);
                cmd.Parameters.AddWithValue("@contrasena", pers.Contrasena);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aumentar el monto ");
            }
            finally
            {
                cerrar();
            }
        }

        public void Insertar(string nombre, string cuenta, string contrasena)//conexion a la base de datos persona agrega cuentas OJO
        {

            try
            {
                string query = "INSERT INTO persona (nombre, cuenta, contrasena) VALUES ('" + nombre + "','" + cuenta + "','" + contrasena + "')";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta en el server");
            }
            cerrar();
        }

        public bool Buscar(string cuenta, string contrasena)
        {
            try
            {
                string query = "SELECT * FROM persona WHERE cuenta='" + cuenta + "' AND contrasena='" + contrasena + "';";
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
                MessageBox.Show("Error al buscar la cuenta en el server");
                return false;
            }
        }



        public persona Busqueda_Usuario(string cuenta, string contrasena)
        {
            persona encontrado = new persona();
            try
            {
                string query = "SELECT * FROM persona WHERE cuenta='" + cuenta + "' AND contrasena='" + contrasena + "';";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    encontrado.Id = Convert.ToInt32(reader["id"]);
                    encontrado.Cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    encontrado.Nombre = Convert.ToString(reader["nombre"]) ?? "";
                    encontrado.Contrasena = Convert.ToString(reader["contrasena"]) ?? "";
                    encontrado.Monto = Convert.ToSingle(reader["monto"]);
                    encontrado.Admin = Convert.ToBoolean(reader["admin"]);
                    return encontrado;
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada");
                    return encontrado;
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar la cuenta en el server");
                return encontrado;
            }
            finally
            {
                cerrar();
            }
        }

        public void Editar(persona per)
        {
            string query = "UPDATE persona SET nombre='" + per.Nombre + "', cuenta='" + per.Cuenta + "', contrasena='" + per.Contrasena + "' WHERE id=" + per.Id + ";";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al momento de editar usuario");
            }
        }


        public List<persona> Consulta()
        {
            List<persona> personas = new List<persona>();
            string query = "SELECT * FROM persona";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    persona per = new persona();
                    per.Id = Convert.ToInt32(reader["id"]);
                    per.Cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    per.Nombre = Convert.ToString(reader["nombre"]) ?? "";
                    per.Contrasena = Convert.ToString(reader["contrasena"]) ?? "";
                    per.Monto = Convert.ToSingle(reader["monto"]);
                    per.Admin = Convert.ToBoolean(reader["admin"]);
                    personas.Add(per);

                }


            }
            catch
            {
                MessageBox.Show("Error Consultar peronas");
            }
            finally
            {
                cerrar();
            }
            return personas;
        }

        public persona BuscarID(int id)
        {
            persona encontrado = new persona();
            string query = "SELECT * FROM persona WHERE id='" + id + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    encontrado.Id = Convert.ToInt32(reader["id"]);
                    encontrado.Cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    encontrado.Nombre = Convert.ToString(reader["nombre"]) ?? "";
                    encontrado.Contrasena = Convert.ToString(reader["contrasena"]) ?? "";
                    encontrado.Monto = Convert.ToSingle(reader["monto"]);
                    encontrado.Admin = Convert.ToBoolean(reader["admin"]);
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada");
                }


            }
            catch
            {
                MessageBox.Show("error al buscar por ID");
            }
            finally
            {
                cerrar();
            }
            return encontrado;
        }





    }
}
