using System;
using System.CodeDom.Compiler;

namespace WeatherApp.exception
{
    public class BadRequest : Exception
    {
        private static string ExceptionMessage { get; } = "Неверный ключ";

        public BadRequest(string message = null) : base(message)
        {
            message = ExceptionMessage;
        }
    }
}