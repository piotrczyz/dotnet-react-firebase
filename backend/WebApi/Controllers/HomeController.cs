using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/FirebaseToken")]
    public async Task<string> Get()
    {
        var firebaseToken = await FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(29593.ToString());
        return firebaseToken;
    }
}