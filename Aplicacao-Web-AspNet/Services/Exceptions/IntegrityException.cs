using System;

namespace Aplicacao_Web_AspNet.Services.Exceptions
{
    public class IntegrityException :ApplicationException
    {
        public IntegrityException(string message) :base (message){  }
    }
}
