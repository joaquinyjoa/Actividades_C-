

namespace Herramientas
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) 
        { }

        public BusinessException(string message, Exception innerException): base(message, innerException) 
        { }
    }
}
