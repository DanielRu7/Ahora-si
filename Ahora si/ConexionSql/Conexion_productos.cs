using Ahora_si.clases;
using MySql.Data.MySqlClient;
using System.Runtime.Intrinsics.X86;

namespace Ahora_si.ConexionSql
{
    public class Conexion_productos
    {
        private string Cadena = "Server=localhost; Database=personal; User=root; Password=; SslMode=none;";
        private MySqlConnection? conexion;
        private List<producto> carrito = new List<producto>();
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


        public bool insertar(producto add)
        {
            try
            {
                string query = "INSERT INTO productos (id, nombre, precio, cantidad, imagen, descripcion) VALUES (@id, @nombre, @precio, @cantidad, @imagen, @descripcion)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", add.Id);
                cmd.Parameters.AddWithValue("@nombre", add.Nombre);
                cmd.Parameters.AddWithValue("@precio", add.Precio);
                cmd.Parameters.AddWithValue("@cantidad", add.Cantidad);
                cmd.Parameters.AddWithValue("@descripcion", add.Descripcion);
                if (add.Imagen == null)
                {
                    cmd.Parameters.AddWithValue("@imagen", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@imagen", add.Imagen);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego Exitosamente!");
                return true;
            }
            catch
            {
                MessageBox.Show("Error al insertar producto en el servidor ");
                return false;
            }
            finally
            {
                cerrar();
            }

        }
        public List<producto> getCarrito()
        {
            List<producto> lista = new List<producto>();
            string query = "SELECT * FROM carrito";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto pro = new producto();
                    pro.Id = Convert.ToInt32(reader["id"]);
                    pro.Nombre = Convert.ToString(reader["nombre"]) ?? "";
                    pro.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    pro.Precio = Convert.ToSingle(reader["precio"]);
                    pro.Descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    pro.Imagen = (byte[])reader["imagen"];


                    lista.Add(pro);

                }


            }
            catch
            {
                MessageBox.Show("Error al obtener el carrito");
            }
            finally
            {
                cerrar();
            }
            return lista;
        }
        public void actualizarMonto(List<producto> aux, string cuenta,string contrasena)
        {
            try
            {
                float montoTotal = 0; // Variable para almacenar el monto total

                foreach (producto pro in aux)
                {
                    montoTotal += pro.Precio;
                }
                Conexion_cuentas conexion_Cuentas = new Conexion_cuentas();
                conexion_Cuentas.actualizarMonto(montoTotal, cuenta,contrasena);
            }
            catch
            {
                MessageBox.Show("Error al agregar producto al carrito");
            }
            finally
            {
                cerrar();
            }

        }
        public void agregarCarroDeCompras(producto pro)
        {
            try
            {



                    string queryReducir = "UPDATE productos SET cantidad = cantidad - 1 WHERE id = @id";
                    MySqlCommand cmdReducir = new MySqlCommand(queryReducir, conexion);
                    cmdReducir.Parameters.AddWithValue("@id", pro.Id);
                    cmdReducir.Parameters.AddWithValue("@cantidad", pro.Cantidad);
                    cmdReducir.ExecuteNonQuery();

                    carrito.Add(pro);
                    string query = "INSERT INTO carrito (id, nombre, precio, cantidad, imagen, descripcion) VALUES (@id, @nombre, @precio, @cantidad, @imagen, @descripcion)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", pro.Id);
                    cmd.Parameters.AddWithValue("@nombre", pro.Nombre);
                    cmd.Parameters.AddWithValue("@precio", pro.Precio);
                    cmd.Parameters.AddWithValue("@cantidad", 1);
                    cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                    if (pro.Imagen == null)
                    {
                        cmd.Parameters.AddWithValue("@imagen", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@imagen", pro.Imagen);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se agrego al carrito de compras");


            }
            catch
            {
                MessageBox.Show("Error al agregar producto al carrito");
            }
            finally
            {
                cerrar();
            }

        }

        public void vaciarCarroDeCompras(List <producto> aux)
        {
            try
            {
                foreach (producto pro in aux)
                {
                    string queryRestaurar = "UPDATE productos SET cantidad = cantidad + @cantidad WHERE id = @id";
                    MySqlCommand cmdRestaurar = new MySqlCommand(queryRestaurar, conexion);
                    cmdRestaurar.Parameters.AddWithValue("@id", pro.Id);
                    cmdRestaurar.Parameters.AddWithValue("@cantidad", pro.Cantidad);
                    cmdRestaurar.ExecuteNonQuery();
                }
                string queryVaciarCarrito = "DELETE FROM carrito";
                MySqlCommand cmdVaciarCarrito = new MySqlCommand(queryVaciarCarrito, conexion);
                cmdVaciarCarrito.ExecuteNonQuery();

                carrito.Clear();

                MessageBox.Show("El carrito ha sido vaciado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al vaciar el carrito");
            }
            finally
            {
                cerrar();
            }
        }


        public List<producto> consulta()
        {
            List<producto> lista = new List<producto>();
            string query = "SELECT * FROM productos";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto pro = new producto();
                    pro.Id = Convert.ToInt32(reader["id"]);
                    pro.Nombre = Convert.ToString(reader["nombre"]) ?? "";
                    pro.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    pro.Precio = Convert.ToSingle(reader["precio"]);
                    pro.Descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    pro.Imagen = (byte[])reader["imagen"];


                    lista.Add(pro);

                }


            }
            catch
            {
                MessageBox.Show("Error al mostrar");
            }
            finally
            {
                cerrar();
            }
            return lista;
        }


        //editar
        public producto BuscarNombre(int posicion)
        {

            List<producto> lista = consulta();
            producto pro = lista[posicion];
            return pro;

        }

        public bool Actualizar(producto pro)
        {
            try
            {
                string query = "UPDATE productos SET nombre = @nombre, precio = @precio, cantidad = @cantidad, imagen = @imagen, descripcion = @descripcion WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", pro.Id);
                cmd.Parameters.AddWithValue("@nombre", pro.Nombre);
                cmd.Parameters.AddWithValue("@precio", pro.Precio);
                cmd.Parameters.AddWithValue("@cantidad", pro.Cantidad);
                cmd.Parameters.AddWithValue("@imagen", pro.Imagen);
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizó exitosamente!");
                return true;
            }
            catch
            {
                MessageBox.Show("Error al actualizar Datos");
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public void Eliminar(producto borrar)
        {
            string query = "DELETE FROM productos WHERE id=" + borrar.Id + ";";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();


            }
            catch
            {
                MessageBox.Show("Error al borrar...");
            }
            finally
            {
                cerrar();
            }



        }




    }
}
