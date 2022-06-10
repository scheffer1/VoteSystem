using Microsoft.AspNetCore.Mvc;
using VoteSystem.Models;

namespace VoteSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class PollController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            return Ok("");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}