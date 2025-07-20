// File: Controllers/HelloController.cs
using Microsoft.AspNetCore.Mvc;
namespace HwRestApp.Controllers;


[ApiController]
[Route("api/hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello, world!";
}

