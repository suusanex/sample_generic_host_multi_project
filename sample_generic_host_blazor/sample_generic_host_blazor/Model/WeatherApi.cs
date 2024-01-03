using sample_generic_host_blazor.Components.Pages;

namespace sample_generic_host_blazor.Model
{
    public class WeatherApi
    {
        public async Task<WeatherForecast[]> GetWeatherForecast()
        {

            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);

            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
