using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal.DataAcces
{
    internal class Mascotas
    {
        private string connectionString = "Server=localhost; Database=examenfinal;Uid=root;Pwd=DMBDAD";


        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public DataTable LeerMascotas()
        {
            DataTable mascotas = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM mascotas ";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(mascotas);
                    }

                }



            }
            return mascotas;

        }
        public int AñadirMascota(string tipo_mascota, string raza, string nombre, string sexo, DateTime fecha_nacimiento, string color, string nombre_dueño, string telefono)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (string.IsNullOrEmpty(tipo_mascota))
                    {
                        MessageBox.Show("Error: El campo 'Tipo Mascota' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(raza))
                    {
                        MessageBox.Show("Error: El campo 'Raza' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("Error: El campo 'Nombre' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(sexo))
                    {
                        MessageBox.Show("Error: El campo 'sexo' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(color))
                    {
                        MessageBox.Show("Error: El campo 'Color' no puede estar vacío.");
                        return -1;
                    }

                    if (fecha_nacimiento == DateTime.MinValue)
                    {
                        MessageBox.Show("Error: Debe ingresar una fecha de nacimiento valida.");
                        return -1;
                    }
                    if (string.IsNullOrEmpty(nombre_dueño))
                    {
                        MessageBox.Show("Error: El campo 'Nombre Dueño' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(telefono))
                    {
                        MessageBox.Show("Error: El campo 'Telefono' no puede estar vacío.");
                        return -1;
                    }

                    string sql = "INSERT INTO mascotas (tipo_mascota, raza, nombre, sexo, fecha_nacimiento, color, nombre_dueño, telefono) VALUES (@tipo_mascota, @raza, @nombre, @sexo, @fecha_nacimiento, @color, @nombre_dueño, @telefono)";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tipo_mascota", tipo_mascota);
                        command.Parameters.AddWithValue("@raza", raza);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@sexo", sexo);
                        command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        command.Parameters.AddWithValue("@color", color);
                        command.Parameters.AddWithValue("@nombre_dueño", nombre_dueño);
                        command.Parameters.AddWithValue("@telefono", telefono);


                        return command.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir mascota: " + ex.Message);
                    throw;
                }
                finally { connection.Close(); }
            }

        }
        public int EliminarMascota(int id_Mascota)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    connection.Open();

                    string sql = "DELETE FROM mascotas WHERE id_mascota= @id_Mascota";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id_Mascota", id_Mascota);
                        int no = command.ExecuteNonQuery();
                        if (no == 0)
                        {
                            MessageBox.Show("Error: No se encontro ninguna mascota con el id ingresado");
                        }

                        return command.ExecuteNonQuery();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Error al eliminar mascota " + ex.Message);
                    throw;
                }
                finally { connection.Close(); }
            }
        }
        public int ActualizarMascota(int id_Mascota, string tipo_mascota, string raza, string nombre, string sexo, DateTime fecha_nacimiento, string color, string nombre_dueño, string telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();

                    string sql = "UPDATE Mascotas SET tipo_mascota = @tipo_mascota, raza = @raza, nombre = @nombre, sexo = @sexo," +
                        " fecha_nacimiento = @fecha_nacimiento, color = @color, nombre_dueño = @nombre_dueño, telefono = @telefono WHERE id_Mascota = @id_Mascota";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tipo_mascota", tipo_mascota);
                        command.Parameters.AddWithValue("@raza", raza);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@sexo", sexo);
                        command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        command.Parameters.AddWithValue("@color", color);
                        command.Parameters.AddWithValue("@nombre_dueño", nombre_dueño);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@id_Mascota", id_Mascota);

                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    return -1;
                }


        }

       
    }

    

}
