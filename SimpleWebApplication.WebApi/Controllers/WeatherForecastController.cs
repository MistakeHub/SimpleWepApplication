using Microsoft.AspNetCore.Mvc;
using SimpleWebApplication.Domain.Models;
using SimpleWebApplication.Infrastructure.Data;

namespace SimpleWebApplication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        ApiContext context;

       
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApiContext _context)
        {
            _logger = logger;
            context = _context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<Company> Get()
        {
            return context.Companies.Local.ToList<Company>();
        }
    }
}