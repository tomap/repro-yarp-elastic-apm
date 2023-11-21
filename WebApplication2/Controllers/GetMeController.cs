using Microsoft.AspNetCore.Mvc;

namespace BackendServer.Controllers;

[ApiController]
[Route("[controller]")]
public class GetMeController : ControllerBase
{
    [HttpGet]
    public async Task<string> Get()
    {
        return "from backend: " + await new HttpClient().GetStringAsync("http://localhost:5678/weatherforecast");
    }
}