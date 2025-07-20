using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
namespace HwRestApp.Controllers;


[ApiController]
[Route("api/info")]
public class InfoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var info = new
        {
            OSDescription = RuntimeInformation.OSDescription,
            OSArchitecture = RuntimeInformation.OSArchitecture.ToString(),
            ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
            Framework = RuntimeInformation.FrameworkDescription,
            MachineName = Environment.MachineName,
            UserName = Environment.UserName,
            ProcessorCount = Environment.ProcessorCount,
            SystemDirectory = Environment.SystemDirectory,
            CurrentDirectory = Environment.CurrentDirectory,
            Is64BitOS = Environment.Is64BitOperatingSystem,
            Is64BitProcess = Environment.Is64BitProcess,
            UptimeMinutes = (int)(DateTime.Now - Environment.TickCount64.ToDateTimeFromTicks()).TotalMinutes,
            DotnetVersion = Environment.Version.ToString(),
            EnvironmentVariables = Environment.GetEnvironmentVariables()
        };

        return Ok(info);
    }
}

public static class TickCountExtensions
{
    public static DateTime ToDateTimeFromTicks(this long tickCount)
    {
        return DateTime.Now - TimeSpan.FromMilliseconds(tickCount);
    }
}
