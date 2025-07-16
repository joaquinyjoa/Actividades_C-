using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public static class PersonajeDAO
    {
        public static Personaje ObtenerPersonajePorId (int id)
        {
            Personaje personaje = null;
            string conexion = @"Data Source=DESKTOP-NBSF9OT\SQLEXPRESS;Initial Catalog=COMBATE_DB;Integrated Security=True;";

            SqlConnection connection; // Puente.
            SqlCommand command;      // Quien lleva la consulta.
            SqlDataReader reader;   // Quien trae los datos.

            using (connection = new SqlConnection(conexion)) 
            {
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "SELECT * FROM personajes WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                reader = command.ExecuteReader();//lee el registro

                if (reader.Read()) // Necesario para posicionarse en el primer registro
                {
                    decimal idJugador = Convert.ToDecimal(reader["id"]);
                    string nombre = reader["nombre"].ToString();
                    string titulo = reader["titulo"].ToString(); // Maneja posibles NULLs
                    short nivel = Convert.ToInt16(reader["nivel"]);
                    int clase = Convert.ToInt32(reader["clase"]);

                    switch (clase) 
                    {
                        case 1:
                            personaje = new Gerrero(idJugador, nombre, titulo, nivel);
                            break;
                        case 2:
                            personaje = new Hechicero(idJugador, nombre, titulo, nivel);
                            break;
                        default:
                            throw new BusinessException($"Clase de personaje no válida: {clase}");
                    }
                }

            }

            return personaje;
        }
    }
}
