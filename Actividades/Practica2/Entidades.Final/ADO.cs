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
        //    SqlConnection connection; // Puente.
        //    SqlCommand command;      // Quien lleva la consulta.
        //    SqlDataReader reader;   // Quien trae los datos.

        //    using (connection = new SqlConnection(conexion))
        //    {
        //        command = new SqlCommand();
        //        command.CommandType = CommandType.Text;
        //        command.Connection = connection;
        //        command.CommandText = "INSERT INTO USUARIOS (EMAIL, CLAVE, NOMBRE, APELLIDO, DNI) VALUES (@correo, @clave, @nombre, @apellido, @dni)";

        //        // Parámetros
        //        command.Parameters.AddWithValue("@correo", user.Correo);
        //        command.Parameters.AddWithValue("@clave", user.Clave);
        //        command.Parameters.AddWithValue("@nombre", user.Nombre);
        //        command.Parameters.AddWithValue("@apellido", user.Apellido);
        //        command.Parameters.AddWithValue("@dni", user.Dni);

        //        connection.Open();

        //        int count = command.ExecuteNonQuery();

        //        return count > 0;
        //    }
        //}

        public bool Agregar(Usuario user)
        {
            // Verificar si el apellido ya existe
            List<Usuario> usuarios = ObtenerTodos();
            List<Usuario> coincidencias = usuarios
                .Where(u => u.Apellido.Equals(user.Apellido, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (coincidencias.Any())
            {
                // Disparar el evento
                ApellidoUsuarioExistente?.Invoke(this, coincidencias);
                return false; // Evita agregar si el apellido ya existe (según lo que pide el enunciado)
            }

            // Si no hay coincidencia, se agrega
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


        public bool Eliminar(Usuario user)
        {
            SqlConnection connection; // Puente.
            SqlCommand command;      // Quien lleva la consulta.
            SqlDataReader reader;   // Quien trae los datos.

            using (connection = new SqlConnection(conexion))
            {
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"DELETE FROM USUARIOS WHERE DNI = @dni";

                // Parámetros
                command.Parameters.AddWithValue("@dni", user.Dni);

                connection.Open();

                int count = command.ExecuteNonQuery();

                return count > 0;
            }
        }

        public bool Modificar(Usuario user)
        {
            SqlConnection connection; // Puente.
            SqlCommand command;      // Quien lleva la consulta.
            SqlDataReader reader;   // Quien trae los datos.

            using (connection = new SqlConnection(conexion))
            {
                command = new SqlCommand();
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

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(conexion))
            using (SqlCommand command = new SqlCommand("SELECT * FROM USUARIOS", connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario user = new Usuario();

                        // Asumiendo que las columnas se llaman igual que las propiedades
                        user.Correo = reader["EMAIL"].ToString();
                        user.Clave = reader["CLAVE"].ToString();
                        user.Nombre = reader["NOMBRE"].ToString();
                        user.Apellido = reader["APELLIDO"].ToString();
                        user.Dni = Convert.ToInt32(reader["DNI"]);

                        listaUsuarios.Add(user);
                    }
                }
            }

            return listaUsuarios;
        }
    }
}
