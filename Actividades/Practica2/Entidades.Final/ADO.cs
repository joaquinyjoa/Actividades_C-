using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class ADO
    {
        // Delegado: qué tipo de método puede suscribirse al evento
        public delegate void ApellidoExistenteHandler(object sender, List<Usuario> usuariosConApellido);

        private static ADO instancia; // Instancia única
        private string conexion;

        // Evento que se dispara si el apellido ya existe
        public event ApellidoExistenteHandler ApellidoUsuarioExistente;

        private ADO() 
        {
            this.conexion = @"Data Source=DESKTOP-NBSF9OT\SQLEXPRESS;Initial Catalog=LOGIN_DB;Integrated Security=True;";
        }

        // Propiedad para acceder a la instancia única
        public static ADO Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ADO();
                }
                return instancia;
            }
        }

        //public bool Agregar(Usuario user) 
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(conexion))
        //        {
        //            SqlCommand command = new SqlCommand();
        //            command.CommandType = CommandType.Text;
        //            command.Connection = connection;
        //            command.CommandText = "INSERT INTO USUARIOS (EMAIL, CLAVE, NOMBRE, APELLIDO, DNI) VALUES (@correo, @clave, @nombre, @apellido, @dni)";
        //
        //            command.Parameters.AddWithValue("@correo", user.Correo);
        //            command.Parameters.AddWithValue("@clave", user.Clave);
        //            command.Parameters.AddWithValue("@nombre", user.Nombre);
        //            command.Parameters.AddWithValue("@apellido", user.Apellido);
        //            command.Parameters.AddWithValue("@dni", user.Dni);
        //
        //            connection.Open();
        //
        //            int count = command.ExecuteNonQuery();
        //
        //            return count > 0;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error al insertar usuario (versión antigua).", ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error inesperado al agregar usuario (versión antigua).", ex);
        //    }
        //}

        /// <summary>
        /// Agrega un nuevo usuario a la base de datos.
        /// Si ya existe un usuario con el mismo apellido, dispara el evento ApellidoUsuarioExistente y no lo agrega.
        /// </summary>
        /// <param name="user">El usuario a agregar.</param>
        /// <returns>True si el usuario fue agregado correctamente; false si ya existía un apellido coincidente.</returns>
        public bool Agregar(Usuario user)
        {
            try
            {
                List<Usuario> usuarios = ObtenerTodos();
                List<Usuario> coincidencias = usuarios
                    .Where(u => u.Apellido.Equals(user.Apellido, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (coincidencias.Any())
                {
                    ApellidoUsuarioExistente?.Invoke(this, coincidencias);
                    return false;
                }

                using (SqlConnection connection = new SqlConnection(conexion))
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO USUARIOS (EMAIL, CLAVE, NOMBRE, APELLIDO, DNI) VALUES (@correo, @clave, @nombre, @apellido, @dni)";

                    command.Parameters.AddWithValue("@correo", user.Correo);
                    command.Parameters.AddWithValue("@clave", user.Clave);
                    command.Parameters.AddWithValue("@nombre", user.Nombre);
                    command.Parameters.AddWithValue("@apellido", user.Apellido);
                    command.Parameters.AddWithValue("@dni", user.Dni);

                    connection.Open();
                    int count = command.ExecuteNonQuery();

                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                // Error específico de SQL Server
                throw new Exception("Error al agregar usuario en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al intentar agregar el usuario.", ex);
            }
        }

        /// <summary>
        /// Elimina un usuario de la base de datos usando el DNI como identificador.
        /// </summary>
        /// <param name="user">El usuario a eliminar.</param>
        /// <returns>True si se eliminó correctamente; false si no se encontró el usuario.</returns>
        public bool Eliminar(Usuario user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM USUARIOS WHERE DNI = @dni";

                    command.Parameters.AddWithValue("@dni", user.Dni);

                    connection.Open();
                    int count = command.ExecuteNonQuery();

                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el usuario.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al intentar eliminar el usuario.", ex);
            }
        }

        /// <summary>
        /// Modifica los datos de un usuario en la base de datos usando el DNI como identificador.
        /// </summary>
        /// <param name="user">El usuario con los datos actualizados.</param>
        /// <returns>True si se modificó correctamente; false si no se encontró el usuario.</returns>
        public bool Modificar(Usuario user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = @"UPDATE USUARIOS SET EMAIL = @correo, CLAVE = @clave, NOMBRE = @nombre, APELLIDO = @apellido WHERE DNI = @dni";

                    command.Parameters.AddWithValue("@correo", user.Correo);
                    command.Parameters.AddWithValue("@clave", user.Clave);
                    command.Parameters.AddWithValue("@nombre", user.Nombre);
                    command.Parameters.AddWithValue("@apellido", user.Apellido);
                    command.Parameters.AddWithValue("@dni", user.Dni);

                    connection.Open();
                    int count = command.ExecuteNonQuery();

                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al modificar el usuario.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al modificar el usuario.", ex);
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos Usuario recuperados de la base de datos.</returns>
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                using (SqlCommand command = new SqlCommand("SELECT * FROM USUARIOS", connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario user = new Usuario
                            {
                                Correo = reader["EMAIL"].ToString(),
                                Clave = reader["CLAVE"].ToString(),
                                Nombre = reader["NOMBRE"].ToString(),
                                Apellido = reader["APELLIDO"].ToString(),
                                Dni = Convert.ToInt32(reader["DNI"])
                            };

                            listaUsuarios.Add(user);
                        }
                    }
                }

                return listaUsuarios;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener la lista de usuarios.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al obtener los usuarios.", ex);
            }
        }

    }
}
