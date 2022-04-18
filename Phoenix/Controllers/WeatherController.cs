using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Phoenix.Data.Interface;
using Phoenix.Data.Models;
using System.Net;
using static Phoenix.ViewModel.WeatherViewModel;

namespace Phoenix.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherCast _weatherCast;

        public WeatherController(IWeatherCast weatherCast)
        {
            _weatherCast = weatherCast;
        }

        public IActionResult SearchCity()
        {
            var viewModel = new SearchCity();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SearchCity(SearchCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "Weather", new { city = model.CityName });
            }
            return View(model);
        }

        public IActionResult City(string city)
        {
            var weatherResponse = _weatherCast.GetForecast(city);
            City viewModel = new City();

            if (weatherResponse != null)
            {
                viewModel.Name = weatherResponse.Name;
                viewModel.Humidity = weatherResponse.Main.Humidity;
                viewModel.Pressure = weatherResponse.Main.Pressure;
                viewModel.Temp = weatherResponse.Main.Temp;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind = weatherResponse.Wind.Speed;
            }
            return View(viewModel);
        }
    }


}

