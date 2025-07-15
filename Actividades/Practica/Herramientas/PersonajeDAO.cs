using System;
using System.Data;
using System.Data.SqlClient;

namespace Herramientas
{
    public static class PersonajeDAO
    {
        private static string connStr = @"Server=DESKTOP-NBSF9OT\SQLEXPRESS;Database=COMBATE_DB;Integrated Security=True;";

        public static Personaje ObtenerPersonajePorID(decimal id)
        {
            Personaje personaje = null;

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT id, nombre, nivel, clase, titulo FROM personajes WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    short nivel = Convert.ToInt16(reader["nivel"]);
                    int clase = Convert.ToInt32(reader["clase"]);
                    string titulo = reader["titulo"].ToString();

                    switch (clase)
                    {
                        case 0:
                            personaje = new Guerrero(id, nombre, nivel, titulo);
                            break;
                        case 1:
                            personaje = new Hechizero(id, nombre, nivel, titulo);
                            break;
                    }
                }

                reader.Close();
            }

            return personaje;
        }
    }
}
