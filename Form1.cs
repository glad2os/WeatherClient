using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.api;
using WeatherApp.entities;
using WeatherApp.exception;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Api Api { get; } = new Api();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (int) Keys.Enter) return;

            try
            {
                var getCity = Api.GetCity(textBox1.Text);
                string key = getCity.Key;

                var weather = Api.GetCurrentWeather(key);
                var forecast = Api.GetForecasts(key);

                string weatherText = weather.WeatherText;
                currentWeatherLabel.Text = weatherText;

                int currentTemperature = weather.Temperature.Metric.Value;
                currentTempLabel.Text = currentTemperature.ToString("D2") + "°";

                string realFeelTemperature = weather.RealFeelTemperature.Metric.Value + "°";
                currentRealFeelTemperatureLabel.Text = realFeelTemperature;

                string realFeelTemperatureShade = weather.RealFeelTemperatureShade.Metric.Value + "°";
                currentRealFeelTemperatureShadeLabel.Text = realFeelTemperatureShade;

                string wind = weather.Wind.Direction.Degrees + " " + weather.Wind.Direction.Localized;
                WindLabel.Text = wind;

                string windGust = weather.WindGust.Speed.Metric.Value;
                WindGustLabel.Text = windGust;

                string uvIndexText = weather.UVIndexText;
                UVIndexLabel.Text = uvIndexText;

                string visibility = weather.Visibility.Metric.Value + " " + weather.Visibility.Metric.Unit;
                VisibilityLabel.Text = visibility;

                string pressure = weather.Pressure.Metric.Value + " " + weather.Pressure.Metric.Unit;
                PressureLabel.Text = pressure;

                string dewPoint = weather.DewPoint.Metric.Value + " " + weather.DewPoint.Metric.Unit;
                DewPointLabel.Text = dewPoint;

                string relativeHumidity = weather.RelativeHumidity;
                RelativeHumidityLabel.Text = relativeHumidity;

                string cloudCover = weather.CloudCover;
                CloudCoverLabel.Text = cloudCover;

                string ceiling = weather.Ceiling.Metric.Value + " " + weather.Ceiling.Metric.Unit;
                CeilingLabel.Text = ceiling;


                string dayStatus = forecast.DailyForecasts[0].Day.IconPhrase;
                dayStatusLabel.Text = dayStatus;

                string nightStatus = forecast.DailyForecasts[0].Night.IconPhrase;
                nightStatusLabel.Text = nightStatus;

                string DailyTemp = forecast.DailyForecasts[0].Temperature.Minimum.Value + " " +
                                   forecast.DailyForecasts[0].Temperature.Minimum.Unit
                                   + " -- " + forecast.DailyForecasts[0].Temperature.Maximum.Value + " " +
                                   forecast.DailyForecasts[0].Temperature.Maximum.Unit;
                DailyTempLabel.Text = DailyTemp;

                string currentPictureUrl = Api.ApiWeatherIconLink + weather.WeatherIcon.ToString("D2") + "-s.png";
                string dayPictureUrl = Api.ApiWeatherIconLink + forecast.DailyForecasts[0].Day.Icon.ToString("D2") +
                                       "-s.png";
                string nightPictureUrl = Api.ApiWeatherIconLink + forecast.DailyForecasts[0].Night.Icon.ToString("D2") +
                                         "-s.png";
                currentPicture.Load(currentPictureUrl);
                dayPicture.Load(dayPictureUrl);
                nightPicture.Load(nightPictureUrl);
            }
            catch (EmptyData exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (BadRequest exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                // Неожиданная ошибка, автор говнокодер
                MessageBox.Show(exception.Message);
            }

            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}