using Microsoft.AspNetCore.Mvc;
using WebWeatherApp.Models;
using WebWeatherApp.OpenWeatherMap;
using WebWeatherApp.Repositories;

namespace WebWeatherApp.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastRepository _WeatherForecastRepository;

        public WeatherForecastController(IWeatherForecastRepository WeatherForecastRepository)
        {
            _WeatherForecastRepository = WeatherForecastRepository;
        }
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", new { city = model.CityName });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResponse weatherReponse = _WeatherForecastRepository.GetForecast(city);
            City viewModel = new City();
            if (weatherReponse !=null)
            {
                viewModel.Name = weatherReponse.Name;
                viewModel.Temperature = weatherReponse.Main.Temp;
                viewModel.Humidity = weatherReponse.Main.Humidity;
                viewModel.Pressure = weatherReponse.Main.Pressure;
                viewModel.Weather = weatherReponse.Weather[0].Main;
                viewModel.Wind = weatherReponse.Wind.Speed;
            }
            return View(viewModel);
        }
    }
}
