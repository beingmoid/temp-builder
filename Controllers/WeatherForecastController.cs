using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationContext Context;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,ApplicationContext context)
        {
            _logger = logger;
            Context = context;
        }
        
        public string Send() => "hello";

        [HttpGet("Get")]
        public ActionResult Get(int Id) => new JsonResult(this.Context.Templates.Include(x => x.Questions).Where(x => x.Id == Id).ToList());

        [HttpGet("List")]
        public ActionResult Get() => new JsonResult(this.Context.Templates);
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
