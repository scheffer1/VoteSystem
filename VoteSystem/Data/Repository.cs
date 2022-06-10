using System.Linq;
using Microsoft.EntityFrameworkCore;
using VoteSystem.Models;

namespace VoteSystem.Data;

public class Repository : IRepository
{
    private readonly DataContext _context;
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
    
    public async Task<Poll[]> GetOptionsByPollId(int PollId)
    {
        IQueryable<Poll> query = _context.Poll;
        query = query.Include(p => p.Options);
        return await query.ToArrayAsync();
    }
}