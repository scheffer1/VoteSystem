using Microsoft.VisualBasic.CompilerServices;

namespace VoteSystem.Models;

public class Options
{
    public Options(int id, int pollId, string name, int voteCounter)
    {
        this.id = id;
        PollId = pollId;
        this.name = name;
        this.voteCounter = voteCounter;
    }

    public int id { get; set; }
    public int PollId { get; set; }
    public Poll poll  { get; set; }
    public string name { get; set; }
    public int voteCounter { get; set; }
}
