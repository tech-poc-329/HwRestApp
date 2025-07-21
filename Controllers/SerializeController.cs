using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HwRestApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SerializeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var data = new
        {
            Name = "Vijay",
            Timestamp = DateTime.UtcNow,
            Message = "This JSON is powered by Newtonsoft.Json"
        };

        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        return Content(json, "application/json");
    }
}
