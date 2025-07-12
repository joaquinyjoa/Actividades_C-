using System.Data;
using System.Data.SqlClient;
internal class Program
{
    private static void Main(string[] args)
    {

        string conexion = @"Data Source=DESKTOP-NBSF9OT\SQLEXPRESS;Initial Catalog=EMPRESA_DB;Integrated Security=True;";

        SqlConnection connection; // Puente.
        SqlCommand command;      // Quien lleva la consulta.
        SqlDataReader reader;   // Quien trae los datos.

        using (connection = new SqlConnection(conexion))
        {
            try
            {
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "SELECT * FROM EMPRESA";

                connection.Open();

                reader = command.ExecuteReader();

                //PUNTO 4

                #region SELECT * FROM EMPRESA
                //reader.GetInt32(0) // Para columna índice 0 (primer columna), si es int
                //reader.GetString(1) // Para columna índice 1, si es string
                Console.WriteLine("SELECT * FROM EMPRESA");
                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                    }

                    Console.WriteLine(new string('-', 30)); // separador entre registros

                    //Console.WriteLine(reader[0]);  // Muestra valor de la primera columna
                }

                #endregion

                #region SELECT NOMBRE FROM EMPRESA
                //IMPORTANTE: cerrar el reader antes de ejecutar otro
                reader.Close();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA");
                command.CommandText = "SELECT NOMBRE FROM EMPRESA";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = 1
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = 1");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = 1";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE SALARIO > 200000
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE SALARIO > 200000");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE SALARIO > @salario";
                command.Parameters.AddWithValue("@salario", 200000);
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE FECHA_ALTA >= 07/06/2012
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE FECHA_ALTA >= 07/06/2012"); // separador entre registros
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE FECHA_ALTA >= @fecha";
                command.Parameters.AddWithValue("@fecha", new DateTime(2012, 6, 7));
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE MAIL LIKE '%gmail%'
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE MAIL LIKE '%gmail%'");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE MAIL LIKE '%gmail%'";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE APELLIDO LIKE 'B%'
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE APELLIDO LIKE 'B%'");
                reader.Close();
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE APELLIDO LIKE 'B%'";
                reader = command.ExecuteReader();//lee el registro

                while (reader.Read())//devuelve true si encuentra filas
                {
                    // Recorremos todas las columnas de esta fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }

                }
                Console.WriteLine(new string('-', 50)); // separador entre registros

                #endregion

                //PUNTO 5
                #region SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = 1 AND SALARIO > 300000
                //cerrar y limpiar antes de usar con parametros y hacer consulta
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = @esta_activo AND SALARIO > @salario");
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE ESTA_ACTIVO = @esta_activo AND SALARIO > @salario";
                command.Parameters.AddWithValue("@salario", 300000);
                command.Parameters.AddWithValue("@esta_activo", true);
                reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    for (int i = 0; i < reader.FieldCount; i++) 
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));

                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL AND ESTA_ACTIVO = 1
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL AND ESTA_ACTIVO = 1");
                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NULL AND ESTA_ACTIVO = @esta_activo";
                command.Parameters.AddWithValue("@esta_activo", true);
                reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    for(int i = 0;i < reader.FieldCount; i++) 
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL AND MAIL LIKE 'a%'
                reader.Close();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL AND MAIL LIKE 'a%'");

                command.CommandText = "SELECT NOMBRE FROM EMPRESA WHERE MAIL IS NOT NULL AND NOMBRE LIKE '%a%'";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE SALARIO >= 250000 AND FECHA_ALTA >= 2000 OR SALARIO < 250000 AND FECHA_ALTA < 2000
                reader.Close();
                command.Parameters.Clear();
                string primeraValidacion = "SALARIO >= @salario AND FECHA_ALTA >= @año";
                string segundaValidacion = "SALARIO < @salario AND FECHA_ALTA < @año";
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE SALARIO >= 250000 AND FECHA_ALTA >= 2000 OR SALARIO < 250000 AND FECHA_ALTA < 2000");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA WHERE {primeraValidacion} OR {segundaValidacion}";
                command.Parameters.AddWithValue("@salario", 250000);
                command.Parameters.AddWithValue("@año", new DateTime(2000, 1, 1));
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE SALARIO BETWEEN 100000 AND 250000
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE SALARIO BETWEEN 100000 AND 250000");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA WHERE SALARIO BETWEEN @minimo AND @maximo";
                command.Parameters.AddWithValue("@minimo", 100000);
                command.Parameters.AddWithValue("@maximo", 250000);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE SALARIO BETWEEN 100000 AND 250000
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE SALARIO NOT BETWEEN  100000 AND 250000");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA WHERE SALARIO NOT BETWEEN @minimo AND @maximo";
                command.Parameters.AddWithValue("@minimo", 100000);
                command.Parameters.AddWithValue("@maximo", 250000);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO BETWEEN  0 AND 2
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO BETWEEN  0 AND 2");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO BETWEEN  @minimo AND @maximo";
                command.Parameters.AddWithValue("@minimo", 0);
                command.Parameters.AddWithValue("@maximo", 2);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO NOT BETWEEN  0 AND 2
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO NOT BETWEEN 0 AND 2");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA WHERE ID_PUESTO NOT BETWEEN @minimo AND @maximo";
                command.Parameters.AddWithValue("@minimo", 0);
                command.Parameters.AddWithValue("@maximo", 2);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                //PUNTO 6
                #region SELECT APELLIDO FROM EMPRESA WHERE ESTA_ACTIVO = 1 ORDER BY APELLIDO ASC
                reader.Close();
                Console.WriteLine("SELECT APELLIDO FROM EMPRESA WHERE ESTA_ACTIVO = 1 ORDER BY APELLIDO ASC");

                command.CommandText = $"SELECT APELLIDO FROM EMPRESA WHERE ESTA_ACTIVO = 1 ORDER BY APELLIDO ASC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY FECHA_ALTA ASC
                reader.Close();
                Console.WriteLine("SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY FECHA_ALTA ASC");

                command.CommandText = $"SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY FECHA_ALTA ASC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY SALARIO DESC
                reader.Close();
                Console.WriteLine("SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY SALARIO DESC");

                command.CommandText = $"SELECT TOP(3) NOMBRE FROM EMPRESA ORDER BY SALARIO DESC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT NOMBRE FROM EMPRESA ORDER BY SALARIO DESC
                reader.Close();
                Console.WriteLine("SELECT NOMBRE FROM EMPRESA ORDER BY SALARIO DESC");

                command.CommandText = $"SELECT NOMBRE FROM EMPRESA ORDER BY SALARIO DESC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT DISTINCT PUESTO.NIVEL_AUTORIZACION FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO 
                reader.Close();
                Console.WriteLine("SELECT DISTINCT PUESTO.NIVEL_AUTORIZACION FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO");

                command.CommandText = $"SELECT DISTINCT PUESTO.NIVEL_AUTORIZACION FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO ";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                //PUNTO 7
                #region SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO , PUESTO.NOMBRE AS PUESTO FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO 
                reader.Close();
                Console.WriteLine("SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO , PUESTO.NOMBRE AS PUESTO FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO");

                command.CommandText = $"SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO , PUESTO.NOMBRE AS PUESTO " +
                    $"FROM EMPRESA " +
                    $"INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO ";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT EMPRESA.NOMBRE FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE PUESTO.NIVEL_AUTORIZACION = 3
                reader.Close();
                Console.WriteLine("SELECT EMPRESA.NOMBRE FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE PUESTO.NIVEL_AUTORIZACION = 3");

                command.CommandText = $"SELECT EMPRESA.NOMBRE " +
                    $"FROM EMPRESA " +
                    $"INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE PUESTO.NIVEL_AUTORIZACION = 3";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NIVEL_AUTORIZACIONFROM FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO ORDER BY EMPRESA.APELLIDO ASC
                reader.Close();
                Console.WriteLine("SELECT EMPRESA.NOMBRE , EMPRESA.APELLIDO, PUESTO.NIVEL_AUTORIZACIONFROM FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO ORDER BY EMPRESA.APELLIDO ASC");

                command.CommandText = $"SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NIVEL_AUTORIZACION " +
                    $"FROM EMPRESA " +
                    $"INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO ORDER BY EMPRESA.APELLIDO ASC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NOMBRE AS PUESTO FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE EMPRESA.ESTA_ACTIVO = 1 ORDER BY EMPRESA.APELLIDO ASC
                reader.Close();
                Console.WriteLine("SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NOMBRE AS PUESTO FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE EMPRESA.ESTA_ACTIVO = 1 ORDER BY EMPRESA.APELLIDO ASC");

                command.CommandText = $"SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NOMBRE AS PUESTO " +
                    $"FROM EMPRESA " +
                    $"INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO WHERE EMPRESA.ESTA_ACTIVO = 1 ORDER BY EMPRESA.APELLIDO ASC";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region PUESTOS SIN EMPLEADOS
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("PUESTOS SIN EMPLEADOS (LEFT JOIN con IS NULL)");

                command.CommandText = @"
                                        SELECT PUESTO.NOMBRE
                                        FROM PUESTO
                                        LEFT JOIN EMPRESA ON PUESTO.ID_PUESTO = EMPRESA.ID_PUESTO
                                        WHERE EMPRESA.ID_PUESTO IS NULL";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["NOMBRE"]);
                }
                Console.WriteLine(new string('-', 50));
                reader.Close();
                #endregion

                #region PUESTOS CON EMPLEADOS
                command.Parameters.Clear();
                Console.WriteLine("PUESTOS CON EMPLEADOS (INNER JOIN DISTINCT)");

                command.CommandText = @"
                                        SELECT DISTINCT PUESTO.NOMBRE
                                        FROM PUESTO
                                        INNER JOIN EMPRESA ON PUESTO.ID_PUESTO = EMPRESA.ID_PUESTO";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["NOMBRE"]);
                }
                Console.WriteLine(new string('-', 50));
                reader.Close();
                #endregion

                #region PROMEDIO DE SALARIOS
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT AVG(SALARIO) AS PROMEDIO_SALARIO FROM EMPRESA WHERE ESTA_ACTIVO = 1");

                command.CommandText = "SELECT AVG(SALARIO) AS PROMEDIO_SALARIO FROM EMPRESA WHERE ESTA_ACTIVO = 1";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"PROMEDIO_SALARIO : {reader["PROMEDIO_SALARIO"]}");
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT SUM(SALARIO) AS SUMA_SALARIO FROM EMPRESA WHERE ESTA_ACTIVO = 1
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT SUM(SALARIO) AS SUMA_SALARIO FROM EMPRESA WHERE ESTA_ACTIVO = 1");

                command.CommandText = "SELECT SUM(SALARIO) AS SUMA_SALARIO FROM EMPRESA WHERE ESTA_ACTIVO = 1";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"SUMA_SALARIO : {reader["SUMA_SALARIO"]}");
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT COUNT(*) FROM EMPRESA WHERE SALARIO >= 250000
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT COUNT(*) FROM EMPRESA WHERE SALARIO >= 250000");

                command.CommandText = "SELECT COUNT(*) FROM EMPRESA WHERE SALARIO >= 250000";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++) 
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT COUNT(*) FROM EMPRESA WHERE FECHA_ALTA < @fecha
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT COUNT(*) FROM EMPRESA WHERE FECHA_ALTA < @fecha");

                command.CommandText = "SELECT COUNT(*) FROM EMPRESA WHERE FECHA_ALTA < @fecha";
                command.Parameters.AddWithValue("@fecha", new DateTime(2010,1,1));
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT MAX(SALARIO) FROM EMPRESA
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT MAX(SALARIO) FROM EMPRESA");

                command.CommandText = "SELECT MAX(SALARIO) FROM EMPRESA";
                command.Parameters.AddWithValue("@fecha", new DateTime(2010, 1, 1));
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT MIN(PUESTO.NIVEL_AUTORIZACION) FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT MIN(PUESTO.NIVEL_AUTORIZACION) FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO");

                command.CommandText = "SELECT MIN(PUESTO.NIVEL_AUTORIZACION) FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO";
             
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT CONCAT(NOMBRE, '', NOMBRE) FROM EMPRESA
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT CONCAT(NOMBRE, ' ', APELLIDO) FROM EMPRESA");

                command.CommandText = "SELECT CONCAT(NOMBRE, ' ', APELLIDO) FROM EMPRESA";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT CONCAT(EMPRESA.NOMBRE, ' ', EMPRESA.APELLIDO, '' ,PUESTO.NIVEL_AUTORIZACION) FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SELECT CONCAT(EMPRESA.NOMBRE, ' ', EMPRESA.APELLIDO, '' ,PUESTO.NIVEL_AUTORIZACION) FROM EMPRESA INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO");

                command.CommandText = "SELECT CONCAT(EMPRESA.NOMBRE, ' ', EMPRESA.APELLIDO, ' ' ,PUESTO.NIVEL_AUTORIZACION) " +
                    "FROM EMPRESA " +
                    "INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region NOMBRE COMPLETO + PUESTO + AUTORIZACION (INCL. PUESTOS SIN EMPLEADOS)
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("Consulta con nombre completo, puesto y nivel de autorización (incluye puestos sin empleados)");

                command.CommandText = @"
                                        SELECT 
                                            CONCAT(E.NOMBRE, ' ', E.APELLIDO) AS NOMBRE_COMPLETO,
                                            P.NOMBRE AS NOMBRE_PUESTO,
                                            P.NIVEL_AUTORIZACION
                                        FROM PUESTO P
                                        LEFT JOIN EMPRESA E ON E.ID_PUESTO = P.ID_PUESTO";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                //PUESTO 9

                #region SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, COUNT(EMPRESA.ID_PUESTO) AS CANTIDAD_EMPLEADOS FROM PUESTO LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO GROUP BY PUESTO.NOMBRE
                reader.Close();

                Console.WriteLine("SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, COUNT(EMPRESA.ID_PUESTO) AS CANTIDAD_EMPLEADOS FROM PUESTO LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO GROUP BY PUESTO.NOMBRE");

                command.CommandText = @"SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, COUNT(EMPRESA.ID_PUESTO) AS CANTIDAD_EMPLEADOS 
                                        FROM PUESTO
                                        LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO 
                                        GROUP BY PUESTO.NOMBRE";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, COUNT(EMPRESA.ID_PUESTO) AS CANTIDAD_EMPLEADOS FROM PUESTO LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO GROUP BY PUESTO.NOMBRE
                reader.Close();

                Console.WriteLine("SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, COUNT(EMPRESA.ID_PUESTO) AS CANTIDAD_EMPLEADOS FROM PUESTO LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO GROUP BY PUESTO.NOMBRE");

                command.CommandText = @"SELECT PUESTO.NOMBRE AS NOMBRE_PUESTO, AVG(EMPRESA.SALARIO) AS PROMEDIO_SALARIO
                                        FROM PUESTO
                                        LEFT JOIN EMPRESA ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO
                                        GROUP BY PUESTO.NOMBRE";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SELECT TOP 1 NOMBRE, APELLIDO, SALARIO FROM EMPRESA 
                reader.Close();

                Console.WriteLine("SELECT TOP 1 NOMBRE, APELLIDO, SALARIO FROM EMPRESA");

                command.CommandText = @"SELECT TOP 1 NOMBRE, APELLIDO, SALARIO FROM EMPRESA ";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region EMPLEADOS CON EL NIVEL DE AUTORIZACIÓN MÁS ALTO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("EMPLEADOS CON EL NIVEL DE AUTORIZACIÓN MÁS ALTO");

                command.CommandText = @"SELECT EMPRESA.NOMBRE, EMPRESA.APELLIDO, PUESTO.NOMBRE AS NOMBRE_PUESTO, PUESTO.NIVEL_AUTORIZACION
                                        FROM EMPRESA
                                        INNER JOIN PUESTO ON EMPRESA.ID_PUESTO = PUESTO.ID_PUESTO
                                        WHERE PUESTO.NIVEL_AUTORIZACION = (
                                            SELECT MAX(NIVEL_AUTORIZACION) FROM PUESTO
                                        )";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region EMPLEADO MÁS VIEJO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("DATOS DEL EMPLEADO MÁS VIEJO");

                command.CommandText = @"SELECT TOP 1 *
                                        FROM EMPRESA
                                        ORDER BY FECHA_ALTA ASC";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region SALARIOS POR ENCIMA DEL PROMEDIO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("SALARIOS POR ENCIMA DEL PROMEDIO");

                command.CommandText = @"SELECT NOMBRE, APELLIDO, SALARIO
                                        FROM EMPRESA
                                        WHERE SALARIO > (SELECT AVG(SALARIO) FROM EMPRESA)";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)} : {reader[i]}");
                    }
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region CANTIDAD DE EMPLEADOS QUE GANAN POR ENCIMA DEL PROMEDIO
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("CANTIDAD DE EMPLEADOS QUE GANAN POR ENCIMA DEL PROMEDIO");

                command.CommandText = @"SELECT COUNT(*) AS CantidadEmpleadosPorEncimaDelPromedio
                                        FROM EMPRESA
                                        WHERE SALARIO > (SELECT AVG(SALARIO) FROM EMPRESA)";

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine($"{reader.GetName(0)} : {reader[0]}");
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region Agregar el mail mbrock@yahoo.com a Maya Brock
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("Agregar el mail mbrock@yahoo.com a Maya Brock");

                // UPDATE para poner el mail a 'mbrock@yahoo.com' solo para Maya Brock
                command.CommandText = @"UPDATE EMPRESA SET MAIL = @mail WHERE NOMBRE = @nombre AND APELLIDO = @apellido";

                //Agrego los parámetros necesarios para evitar SQL Injection
                command.Parameters.AddWithValue("@mail", "mbrock@yahoo.com");
                command.Parameters.AddWithValue("@nombre", "Maya");
                command.Parameters.AddWithValue("@apellido", "Brock");

                // ExecuteNonQuery devuelve la cantidad de filas afectadas
                int filasAfectadas = command.ExecuteNonQuery();

                Console.WriteLine($"Filas afectadas: {filasAfectadas}");
                Console.WriteLine(new string('-', 50));
                #endregion

                #region Cambiar el puesto de Maya Brock a Administrativo y su salario a $210.000,00.
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("Cambiar el puesto de Maya Brock a Administrativo y su salario a $210.000,00.");

                command.CommandText = @"UPDATE EMPRESA SET ID_PUESTO = 1, SALARIO = 210000 WHERE NOMBRE = @nombre AND APELLIDO = @apellido";

                //Agrego los parámetros necesarios para evitar SQL Injection
                command.Parameters.AddWithValue("@mail", "mbrock@yahoo.com");
                command.Parameters.AddWithValue("@nombre", "Maya");
                command.Parameters.AddWithValue("@apellido", "Brock");

                // ExecuteNonQuery devuelve la cantidad de filas afectadas
                int segundoCambio = command.ExecuteNonQuery();

                Console.WriteLine($"Filas afectadas: {segundoCambio}");
                Console.WriteLine(new string('-', 50));
                #endregion

                #region Dar un aumento del 25% a todos los empleados que ganen menos de $250.000,00.
                reader.Close();
                command.Parameters.Clear();
                Console.WriteLine("Dar un aumento del 25% a todos los empleados que ganen menos de $250.000,00.");

                command.CommandText = @"UPDATE EMPRESA SET SALARIO = 210000 * 1.25 WHERE SALARIO < @salario";

                //Agrego los parámetros necesarios para evitar SQL Injection
                command.Parameters.AddWithValue("@salario", 250000);

                // ExecuteNonQuery devuelve la cantidad de filas afectadas
                int tercerCambio = command.ExecuteNonQuery();

                Console.WriteLine($"Filas afectadas: {tercerCambio}");
                Console.WriteLine(new string('-', 50));
                #endregion

                #region Baja lógica del empleado con ID = 1
                reader.Close();
                command.Parameters.Clear();

                Console.WriteLine("Baja lógica del empleado con ID = 1");

                command.CommandText = @"UPDATE EMPRESA 
                        SET ESTA_ACTIVO = 0, FECHA_BAJA = @fechaBaja 
                        WHERE ID_EMPLEADOS = @id";

                command.Parameters.AddWithValue("@fechaBaja", DateTime.Now);
                command.Parameters.AddWithValue("@id", 3);

                int cuartoCambio = command.ExecuteNonQuery();

                Console.WriteLine($"Filas afectadas: {cuartoCambio}");

                // Verificación
                command.Parameters.Clear();
                command.CommandText = @"SELECT ID_EMPLEADOS, NOMBRE, ESTA_ACTIVO, FECHA_BAJA FROM EMPRESA WHERE ID_PUESTO = @id";
                command.Parameters.AddWithValue("@id", 3);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["ID_EMPLEADOS"]}, Nombre: {reader["NOMBRE"]}, Activo: {reader["ESTA_ACTIVO"]}, Fecha Baja: {reader["FECHA_BAJA"]}");
                }
                Console.WriteLine(new string('-', 50));
                #endregion

                #region Baja física de empleados inactivos
                reader.Close();
                command.Parameters.Clear();

                Console.WriteLine("Baja física de empleados que no estén activos");

                command.CommandText = @"DELETE FROM EMPRESA WHERE ESTA_ACTIVO = 0";

                int filasEliminadas = command.ExecuteNonQuery();

                Console.WriteLine($"Filas eliminadas: {filasEliminadas}");

                // Verificación: contar cuántos empleados inactivos quedan
                command.Parameters.Clear();
                command.CommandText = @"SELECT COUNT(*) FROM EMPRESA WHERE ESTA_ACTIVO = 0";

                object resultado = command.ExecuteScalar();

                Console.WriteLine($"Empleados inactivos restantes: {resultado}");
                Console.WriteLine(new string('-', 50));
                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    } 
}