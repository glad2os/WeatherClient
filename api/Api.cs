using System.Net.Http;
using System.Runtime.Remoting;
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
        private const string WebArgs = "&language=ru-RU&metric=true&details=true";

        private static string ContentFromApi(string requestUri)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(requestUri).Result;
            if (!response.IsSuccessStatusCode) throw new ServerException(response.StatusCode.ToString());
            var content = response.Content.ReadAsStringAsync().Result;
            return content;
        }

        public static dynamic GetCity(string city = DefaultCity)
        {
            var responseDataString = ContentFromApi(ApiCityLink + "&q=" + city + "&language=ru-RU");
            if (responseDataString == null) throw new EmptyData();

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new ServerError("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }

        public dynamic GetForecasts(string forecasts)
        {
            var responseDataString =
                ContentFromApi(ApiForecastLink + forecasts + "?apikey=" + ApiKey + WebArgs);
            if (responseDataString == null) throw new EmptyData();

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new ServerError("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }

        public static dynamic GetCurrentWeather(string key = null)
        {
            var responseDataString = ContentFromApi(ApiCurrentConditionsLink + key + "?apikey=" + ApiKey + WebArgs);
            if (responseDataString == null) throw new EmptyData();

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new ServerError("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }
    }
}