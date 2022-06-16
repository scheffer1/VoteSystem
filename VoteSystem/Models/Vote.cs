namespace VoteSystem.Models;

public class Vote
{
    public Vote() { }

    public Vote(int id, Options options, int idOpts)
    {
        this.id = id;
        this.options = options;
        this.idOpts = idOpts;
    }

    public int id { get; set; }
    
    public Options options { get; set; }

    public int idOpts { get; set; }
}

