using System;

namespace WeatherApp.exception
{
    public class EmptyData : Exception
    {
        private static string ExceptionMessage { get; } = "Empty response";
        
        public EmptyData(string message = null) : base(message)
        {
            message = ExceptionMessage;
        }
    }
}