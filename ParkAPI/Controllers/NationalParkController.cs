using Microsoft.AspNetCore.Mvc;

namespace ParkApi.Controllers;

[ApiController]
[Route("[controller]")]
public class NationalParkController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<NationalParkController> _logger;

    public NationalParkController(ILogger<NationalParkController> logger)
    {
        _logger = logger;
    }


// Used to return a forecast so tailor it
    [HttpGet(Name = "GetNationalPark")]
    public IEnumerable<NationalPark> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new NationalPark
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
