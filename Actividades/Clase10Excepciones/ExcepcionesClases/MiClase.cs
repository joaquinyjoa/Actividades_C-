using ExcepcionesClases;

public class MiClase
{
    // Método estático que lanza DivideByZeroException
    public static void MetodoEstatico()
    {
        throw new DivideByZeroException("Error: División por cero en MetodoEstatico");
    }

    // Primer constructor
    public MiClase()
    {
        try
        {
            MetodoEstatico();
        }
        catch (DivideByZeroException ex)
        {
            // Relanzamos la excepción
            throw ex;
        }
    }

    // Segundo constructor
    public MiClase(bool invocarOtroConstructor)
    {
        try
        {
            // Instancia de MiClase → llama al constructor sin parámetros
            MiClase instancia = new MiClase();
        }
        catch (Exception ex)
        {
            // Captura la excepción del primer constructor y lanza UnaExcepcion
            throw new UnaExcepcion("Error en el segundo constructor de MiClase", ex);
        }
    }
}
