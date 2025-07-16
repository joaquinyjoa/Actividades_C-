using System.Text.Json;
using System.IO;

namespace Entidades.Final
{
    public static class Manejadora
    {
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
            catch
            {
                return false;
            }
        }

        public static bool SerializarJSON(List<Usuario> users, string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeserializarJSON(string path, out List<Usuario> users)
        {
            users = new List<Usuario>();
            try
            {
                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Usuario>>(json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
