using Microsoft.EntityFrameworkCore;

namespace Core;

public abstract class RepositoryProvider<RepositoryType> : DbContext where RepositoryType : class
{
  public abstract DbSet<RepositoryType> Collection { get; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
  }
}
