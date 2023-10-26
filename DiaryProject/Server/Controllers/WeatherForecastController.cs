using DataAccess;
using DataAccess.Models.DanhMuc;
using DiaryProject.Shared;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using Services.Services;
namespace DiaryProject.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController
    {
        private readonly DatabaseContext _dbContext;


        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
       

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IChi_nhanh_Service _service;

        public WeatherForecastController(DatabaseContext databaseContext, IChi_nhanh_Service Service, ILogger<WeatherForecastController> logger)
        {
            _dbContext = databaseContext;
            _logger = logger;
            _service = Service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var data = _service.GetAll();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}