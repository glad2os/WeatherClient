using System;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Newtonsoft.Json;
using WeatherApp.exception;
using WeatherApp.config;
using WeatherApp.entities;
using static System.String;

namespace WeatherApp.api
{
    public class Api
    {
        private const string DefaultCity = "Астрахань";
        private static readonly string ApiKey = "?apikey=" + new Config().ApiKey;

        private static readonly string ApiCityLink =
            "http://dataservice.accuweather.com/locations/v1/cities/search" + ApiKey;

        private const string ApiForecastLink = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/";
        private const string ApiCurrentConditionsLink = "http://dataservice.accuweather.com/currentconditions/v1/";
        private const string WebArgs = "&language=ru-RU&metric=true&details=true";

        public const string ApiWeatherIconLink = "https://developer.accuweather.com/sites/default/files/";
        //n.ToString("D2")

        private static string ContentFromApi(string requestUri)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(requestUri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode && !IsNullOrEmpty(content))
            {
                var accuWeatherError = JsonConvert.DeserializeObject<AccuError>(content);
                throw new BadRequest(accuWeatherError.Message);
            }

            if (!response.IsSuccessStatusCode) throw new BadRequest(response.StatusCode.ToString());
            return content;
        }


        public static dynamic GetCity(string city = DefaultCity)
        {
            var responseDataString = ContentFromApi(ApiCityLink + "&q=" + city + "&language=ru-RU");
            switch (responseDataString)
            {
                case null:
                    throw new EmptyData("Город не найден!");
                case "[]":
                    throw new EmptyData("Город не найден!");
            }

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new BadRequest("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }

        public static dynamic GetForecasts(string cityKey = null)
        {
            var responseDataString =
                ContentFromApi(ApiForecastLink + cityKey + ApiKey + "&language=ru-RU&metric=true");
            if (responseDataString == null) throw new EmptyData();

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new BadRequest("Пустой запрос");

            var dynamicObject = cityDeserializeObject;
            return dynamicObject;
        }

        public static dynamic GetCurrentWeather(string cityKey = null)
        {
            var responseDataString = ContentFromApi(ApiCurrentConditionsLink + cityKey + ApiKey + WebArgs);
            if (responseDataString == null) throw new EmptyData();

            dynamic cityDeserializeObject = JsonConvert.DeserializeObject(responseDataString);
            if (cityDeserializeObject == null) throw new BadRequest("Пустой запрос");

            var dynamicObject = cityDeserializeObject[0];
            return dynamicObject;
        }
    }
}