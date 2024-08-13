using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ServerlessAPI.Controllers;

[Route("api/[controller]")]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<UsersController> logger;

    public UsersController(ApplicationDbContext context, ILogger<UsersController> logger)
    {
        _context = context;
        this.logger = logger;
    }

    // GET api/users
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var users = await _context.Users.ToListAsync();

            return Ok(users);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while getting users");
            return StatusCode(500, "Internal server error");
        }
    }
}