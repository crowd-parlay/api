using Microsoft.AspNetCore.Mvc;

namespace CrowdParlay.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : Controller
{
    [HttpGet]
    public IActionResult Index() => Ok();

    [HttpGet("[action]")]
    public ActionResult<string> Ping() => "Pong";
}