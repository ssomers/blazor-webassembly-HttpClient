using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client
{
    internal class ActualWeatherService(HttpClient Http) : IWeatherService
    {
        public async Task<WeatherForecast[]?> Forecast() => await Http.GetFromJsonAsync<WeatherForecast[]>("api/Weather/Now");
    }
}