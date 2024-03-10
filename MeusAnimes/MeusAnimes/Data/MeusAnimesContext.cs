using MeusAnimes.Models;
using Microsoft.EntityFrameworkCore;

namespace MeusAnimes.Data;

public class MeusAnimesContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Anime> Animes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeusAnimesContext).Assembly);
    }
}
