using Demo.Application.IService;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    /// <summary>
    /// Dependency on UserService
    /// </summary>
    private readonly IUserService _userService;

    /// <summary>
    /// Constructor, initialize the UserService
    /// </summary>
    public UserController(IUserService userService)
    {
        // No need new UserService(), It's already done in Program.cs.
        _userService = userService;
    }

    /// <summary>
    /// Interface to get user information
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns>User json</returns>
    [Route("info")]
    public IActionResult Info(int id)
    {
        var user = _userService.GetById(id);
        return Json(user);
    }

    /// <summary>
    /// Interface to Login
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Login result</returns>
    [Route("login")]
    public IActionResult Login(User user)
    {
        var result = _userService.Login(user);
        return Json(result);
    }
    
    /// <summary>
    /// Interface to Register
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Registry result</returns>
    [Route("register")]
    public IActionResult Register(User user)
    {
        var result = _userService.Reg(user);
        return Json(result);
    }

    /// <summary>
    /// Interface to get all users
    /// </summary>
    /// <returns>Json list</returns>
    [Route("list")]
    public IActionResult List()
    {
        var result = _userService.List();
        return Json(result);
    }
    
    /// <summary>
    /// Interface to check if email is used
    /// </summary>
    /// <param name="email">Email address</param>
    /// <returns>Exist status</returns>
    [Route("exist")]
    public IActionResult ExistsByEmail([FromForm] string email)
    {
        var result = _userService.ExistsByEmail(email);
        return Json(result);
    }
}