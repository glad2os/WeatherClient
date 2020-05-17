using System;
using System.CodeDom.Compiler;

namespace WeatherApp.exception
{
    public class ServerError : Exception
    {
        private static string ExceptionMessage { get; } = "Соси БИбу))";

        public ServerError(string message = null) : base(message)
        {
            message = ExceptionMessage;
        }
    }
}