using VoteSystem.Models;

namespace VoteSystem.DTO;

public class PollsDTO
{
    public string name { get; set; }
    public List<OptionsDTO> Options { get; set; }
}