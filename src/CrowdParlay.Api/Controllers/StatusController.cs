using Microsoft.AspNetCore.Mvc;

namespace CrowdParlay.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : Controller
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Index()
    {
        return Ok();
    }
}