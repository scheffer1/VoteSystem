namespace VoteSystem.Models;

public class Poll
{
    public Poll() {}

    public Poll(ICollection<Options> options, string name, int id, string descri, DateTime horaInicio, DateTime horafinal)
    {
        Options = options;
        this.name = name;
        this.id = id;
        this.descri = descri;
        this.horaInicio = horaInicio;
        this.horafinal = horafinal;
    }

    public ICollection<Options> Options { get; set; }
    public string name { get; set; }

    public int id { get; set; }
    public string descri { get; set; }
    public DateTime horaInicio { get; set; }
    public DateTime horafinal { get; set; }
}