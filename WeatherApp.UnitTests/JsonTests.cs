using System;
using System.Diagnostics;
using NUnit.Framework;
using WeatherApp.api;
using WeatherApp.exception;

namespace WeatherApp.UnitTests
{
    [TestFixture]
    public class JsonTests
    {
        [Test]
        public void GetValidCityTest()
        {
            var getCity = Api.GetCity("Москва");
            string key = getCity.Key;
            Assert.IsNotEmpty(getCity);
            Assert.IsNotNull(getCity);
        }

        [Test]
        public void GetValidCityWeather()
        {
            var getCity = Api.GetCity("Москва");
            string key = getCity.Key;
            var weather = Api.GetCurrentWeather(key);

            string weatherText = weather.WeatherText;
            Assert.IsNotEmpty(weatherText);

            int currentTemperature = weather.Temperature.Metric.Value;
            Assert.NotNull(currentTemperature);

            string currentTemperatureUnit = weather.Temperature.Metric.Unit;
            Assert.AreEqual(currentTemperatureUnit, "C");
        }

        [Test]
        public void GetInvalidCityTest()
        {
            Assert.True(true);
        }

        [Test]
        public void GetInvalidCityWeather()
        {
            Assert.True(true);
        }
    }
}