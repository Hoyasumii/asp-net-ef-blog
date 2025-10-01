using Microsoft.EntityFrameworkCore;

namespace Core.Shared;

public abstract class RepositoryProvider<EntityType> : DbContext where EntityType : Entity
{
  protected DbSet<EntityType> Collection { get; set; }

  protected abstract override void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
}
