using Microsoft.EntityFrameworkCore;
using VoteSystem.Models;

namespace VoteSystem.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Options> Options { get; set; }
    public DbSet<Poll> Poll { get; set; }
    public DbSet<Vote> Vote { get; set; }
    
    public DataContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("TrustServerCertificate=True;Password=mateus02;Persist Security Info=True;User ID=sa;Initial Catalog=VoteSys;Data Source=DESKTOP-INCE99I");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Options>()
            .HasOne<Poll>(s => s.poll)
            .WithMany(o => o.options)
            .HasForeignKey(o => o.PollId);

        modelBuilder.Entity<Poll>()
            .HasKey(p => p.id);

        modelBuilder.Entity<Vote>()
            .HasOne<Options>(p => p.options)
            .WithMany(v => v.Vote)
            .HasForeignKey(v => v.idOpts);

    }
}