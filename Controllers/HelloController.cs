// File: Controllers/HelloController.cs
using Microsoft.AspNetCore.Mvc;
namespace HwRestApp.Controllers;

PATTERNS = [
    re.compile(r'\b\d{3}-?\d{2}-?\d{4}\b'),              
    re.compile(r'\b\d{12}\b'),                           
    re.compile(r'\b0[A-Za-z0-9_-]{63}\b'),               
    re.compile(r'\bAKC[p]?[A-Za-z0-9_-]{40}\b'),         
    re.compile(r'\beyJ[0-9A-Za-z._-]{10,}\.[0-9A-Za-z._-]{10,}\.[0-9A-Za-z._-]{10,}\b'),  
    re.compile(r'(?:password|passwd|pwd)[\s:=]+.*', re.I),
    re.compile(r'\b[nz](?![aeiou])[a-z0-9]{6}\b', re.I),
]


[ApiController]
[Route("api/hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello, world!";
}

