using System.Net.Http;
using Newtonsoft.Json;
using WeatherApp.exception;
using WeatherApp.config;

namespace WeatherApp.api
{
    public class Api
    {
        private const string DefaultCity = "Астрахань";
        private static readonly string ApiKey = new Config().ApiKey;

        private static readonly string ApiCityLink =
            "http://dataservice.accuweather.com/locations/v1/cities/search?apikey=" + ApiKey;

        private const string ApiForecastLink = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/";
        private const string ApiCurrentConditionsLink = "http://dataservice.accuweather.com/currentconditions/v1/";

        private static string LoadData(string requestUri)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(requestUri).Result;

            var content = response.Content.ReadAsStringAsync().Result;
            return content;
        }

        internal static dynamic GetCity(string city = DefaultCity)
        {
            var responseDataString = LoadData(ApiCityLink + "&q=" + city + "&language=ru-RU");
            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);

            if (cityDeserializeObject == null) throw new ServerError("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }
    }
}