using Microsoft.AspNetCore.Mvc;
using ServerlessAPI.Entities;

namespace ServerlessAPI.Controllers;

[Route("api/[controller]")]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> logger;

    public UsersController(ILogger<UsersController> logger)
    {
        this.logger = logger;
    }

    // GET api/users
    [HttpGet]
    public IActionResult Get()
    {
        var user = new User { Id = Guid.NewGuid(), Name = "サンプル" };

        return Ok(user);
    }
}
