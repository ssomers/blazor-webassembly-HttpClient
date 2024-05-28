namespace BlazorApp1.Shared
{
    public interface IWeatherService
    {
        public Task<WeatherForecast[]?> Forecast();
    }

    public sealed class NullWeatherService : IWeatherService
    {
        public Task<WeatherForecast[]?> Forecast() => Task.FromResult<WeatherForecast[]?>(null);
    }
}
