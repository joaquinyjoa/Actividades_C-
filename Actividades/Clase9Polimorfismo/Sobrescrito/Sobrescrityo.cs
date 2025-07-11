namespace Sobrescrito
{
    public abstract class Sobrescrityo
    {
        protected string miAtributo;

        public string MiAtributo 
        {
            get { return this.miAtributo; }
            set { this.miAtributo = value; }
        }

        public Sobrescrityo()
        {
            MiAtributo = "Probar abstractos";
        }

        protected abstract string MiPropiedad();

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override int GetHashCode() 
        {
            return 1142510181;
        }


        public override bool Equals(object? obj)
        {
            bool loEs = true; 

            Sobrescrityo other = obj as Sobrescrityo;

            if (other != obj)
            {
                loEs = false;
            }

            return loEs;
        }


    }
}
