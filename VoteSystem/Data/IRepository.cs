using VoteSystem.Models;

namespace VoteSystem.Data;

public interface IRepository
{
    Task<bool> SaveChangesAsync();
    Task<Poll[]> GetOptionsByPollId(int idPoll);
    Task<Poll[]> getAll();
    
}