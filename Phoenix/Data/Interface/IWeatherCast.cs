using static Phoenix.Data.Models.WeatherModel;

namespace Phoenix.Data.Interface
{
    public interface IWeatherCast
    {
        Root GetForecast(string city);
    }
}
