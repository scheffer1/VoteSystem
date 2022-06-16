using Microsoft.VisualBasic.CompilerServices;

namespace VoteSystem.Models;

public class Options
{
    public Options() {}
    public Options(ICollection<Vote> vote, int id, int pollId, string name)
    {
        Vote = vote;
        this.id = id;
        PollId = pollId;
        this.name = name;
    }

    public ICollection<Vote> Vote { get; set; }
    public int id { get; set; }
    public int PollId { get; set; }
    public Poll poll  { get; set; }
    public string name { get; set; }
    
}
