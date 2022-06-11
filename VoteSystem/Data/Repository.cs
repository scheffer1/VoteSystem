using System.Linq;
using Microsoft.EntityFrameworkCore;
using VoteSystem.Models;

namespace VoteSystem.Data;

public class Repository : IRepository
{
    private readonly DataContext _context;
    public Repository(DataContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);
    }
    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }
    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }
    
    public async Task<Poll[]> GetOptionsByPollId(int idPoll)
    {
        IQueryable<Poll> query = _context.Poll;
        query = query.Include("Options").Where(poll => poll.id == idPoll);
        return await query.ToArrayAsync();
    }
    
    public async Task<Poll[]> getAll()
    {
        IQueryable<Poll> query = _context.Poll;
        query = query;
        return await query.ToArrayAsync();
    }
}