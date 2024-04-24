using System;
namespace Aplicacao_Web_AspNet.Services.Exceptions
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) :base(message) 
        {

        }
    }
}
