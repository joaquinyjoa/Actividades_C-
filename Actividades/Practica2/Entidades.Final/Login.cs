using System.Data;
using System.Data.SqlClient;

namespace Entidades.Final
{
    public class Login
    {
        private string email;
        private string pass;

        public string Email 
        {
            get { return this.email; }
        }

        public string Pass 
        {
            get { return this.pass; }
        }

        public Login(string correo, string clave) 
        {
            this.email = correo;
            this.pass = clave;
        }

        public bool Loguear() 
        {
            string conexion = @"Data Source=DESKTOP-NBSF9OT\SQLEXPRESS;Initial Catalog=LOGIN_DB;Integrated Security=True;";

            SqlConnection connection; // Puente.
            SqlCommand command;      // Quien lleva la consulta.
            SqlDataReader reader;   // Quien trae los datos.

            using (connection = new SqlConnection(conexion)) 
            {
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "SELECT * FROM USUARIOS WHERE EMAIL = @correo AND CLAVE = @clave" ;

                // Parámetros
                command.Parameters.AddWithValue("@correo", this.email);
                command.Parameters.AddWithValue("@clave", this.pass);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
