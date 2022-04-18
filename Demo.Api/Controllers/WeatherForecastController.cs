using Demo.Application.IService;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    private readonly IUserService _userService;

    public WeatherForecastController(IUserService userService1, IUserService userService2)
    {
        _userService = userService1;
        Console.WriteLine(userService1.GetHashCode());
        Console.WriteLine(userService2.GetHashCode());
    }

    [HttpGet("values")]
    public ActionResult<IEnumerable<string>> GetHashCode()
    {
        return new String[] { "value1", "value2" };
    }
}