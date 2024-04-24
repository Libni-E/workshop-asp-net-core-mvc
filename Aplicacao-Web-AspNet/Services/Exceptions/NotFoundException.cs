using System;
namespace Aplicacao_Web_AspNet.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }



    }
}
