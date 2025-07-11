namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }

                return string.Empty;
            }

            set
            {
                if (i >= 0 && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                else if (i == paginas.Count)
                {
                    // Si el índice es igual al tamaño, agregás el nuevo valor al final
                    paginas.Add(value);
                }
                else
                {
                    // Si el índice es mayor al tamaño, agregás páginas vacías hasta llegar al índice deseado
                    while (paginas.Count < i)
                    {
                        paginas.Add(string.Empty);
                    }

                    // Ahora agregás el valor en la posición correcta
                    paginas.Add(value);
                }
            }
        }

    }
}
