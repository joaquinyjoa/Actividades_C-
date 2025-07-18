﻿using System.Text.Json;
using System.IO;

namespace Entidades.Final
{
    public static class Manejadora
    {
        /// <summary>
        /// Escribe información de una lista de usuarios en un archivo de texto (.log) en la carpeta Documentos del usuario.
        /// Guarda la fecha actual, el apellido del primer usuario y los correos electrónicos de todos los usuarios.
        /// </summary>
        /// <param name="users">Lista de usuarios cuyos datos se van a registrar.</param>
        /// <returns>True si el archivo fue escrito correctamente, false si ocurrió algún error.</returns>
        public static bool EscribirArchivo(List<Usuario> users)
        {
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "usuarios.log");

                using (StreamWriter writer = new StreamWriter(ruta, append: true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    if (users.Count > 0)
                    {
                        string apellido = users[0].Apellido;
                        writer.WriteLine($"Apellido: {apellido}");

                        foreach (var u in users)
                        {
                            writer.WriteLine($" - {u.Correo}");
                        }
                    }

                    writer.WriteLine(); // línea en blanco para separar entradas
                }

                return true;
            }
            catch (IOException ex)
            {
                // Error relacionado con el sistema de archivos
                Console.WriteLine($"Error de I/O al escribir el archivo: {ex.Message}");
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Acceso denegado al escribir el archivo: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al escribir el archivo: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Serializa una lista de usuarios al formato JSON y la guarda en un archivo en la ruta especificada.
        /// </summary>
        /// <param name="users">Lista de usuarios a serializar.</param>
        /// <param name="path">Ruta del archivo donde se guardará el JSON.</param>
        /// <returns>True si la serialización fue exitosa, false si ocurrió algún error.</returns>
        public static bool SerializarJSON(List<Usuario> users, string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Acceso denegado al escribir JSON: {ex.Message}");
                return false;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al escribir JSON: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al serializar JSON: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Deserializa el contenido de un archivo JSON a una lista de objetos Usuario.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON a deserializar.</param>
        /// <param name="users">Lista de usuarios resultante, si la operación fue exitosa.</param>
        /// <returns>True si la deserialización fue exitosa, false si ocurrió algún error.</returns>
        public static bool DeserializarJSON(string path, out List<Usuario> users)
        {
            users = new List<Usuario>();

            try
            {
                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Usuario>>(json);
                return true;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Archivo JSON no encontrado: {ex.Message}");
                return false;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error en el formato JSON: {ex.Message}");
                return false;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al leer JSON: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al deserializar JSON: {ex.Message}");
                return false;
            }
        }
    }
}
