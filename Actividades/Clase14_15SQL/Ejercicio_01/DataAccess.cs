using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio_01
{
    public class DataAccess
    {
        private string conexion = @"Data Source=DESKTOP-NBSF9OT\SQLEXPRESS;Initial Catalog=EMPRESA_DB;Integrated Security=True;";

        public List<Dictionary<string, object>> ObtenerDatosDeEmpresa()
        {
            var resultados = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM EMPRESA", connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fila = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                fila[reader.GetName(i)] = reader[i];
                            }
                            resultados.Add(fila);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
            }

            return resultados;
        }
    }
}
