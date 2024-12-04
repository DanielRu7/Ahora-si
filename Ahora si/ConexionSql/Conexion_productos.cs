﻿using Ahora_si.clases;
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
                cmd.Parameters.AddWithValue("@imagen", add.Imagen);
                cmd.Parameters.AddWithValue("@descripcion", add.Descripcion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego Exitosamente!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto en el servidor ");
                return false;
            }
            finally
            {
                cerrar();
            }
            
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
                    pro.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    pro.Precio = Convert.ToSingle(reader["precio"]);
                    pro.Descripcion = Convert.ToString(reader["descripcion"])??"";
                    pro.Imagen = (byte[])reader.GetValue(4);

                    lista.Add(pro);

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
