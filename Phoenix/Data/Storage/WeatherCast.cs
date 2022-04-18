using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using static Phoenix.Data.Models.WeatherModel;
using Phoenix.Data.Interface;

namespace Phoenix.Data.Storage
{
    public class WeatherCast : IWeatherCast
    {
        const string API = "6b44f6461118c250a9f3785de0b629e8";
        Root IWeatherCast.GetForecast(string city)
        {
            string IDOWeather = API;

            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);

                // Deserialize the JToken object into our WeatherResponse Class
                return content.ToObject<Root>();
            }

            return null;
        }
    }
}
