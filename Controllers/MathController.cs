// File: Controllers/MathController.cs
using Microsoft.AspNetCore.Mvc;
namespace HwRestApp.Controllers;


[ApiController]
[Route("api/math")]
public class MathController : ControllerBase
{
    [HttpGet("add")]
    public int Add([FromQuery] int a, [FromQuery] int b) => a + b;
}
