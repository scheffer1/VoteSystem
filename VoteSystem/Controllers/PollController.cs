using Microsoft.AspNetCore.Mvc;
using VoteSystem.Data;
using VoteSystem.Models;

namespace VoteSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PollController : ControllerBase
{
    public IRepository _repo { get; }

    public PollController(IRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("/api/{idPoll}")]
    public async Task<IActionResult> Get(int idPoll)
    {
        try
        {
            var result = await _repo.GetOptionsByPollId(idPoll);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    [HttpGet("/api/getAll")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _repo.getAll();
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}