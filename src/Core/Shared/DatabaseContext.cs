using Microsoft.EntityFrameworkCore;

namespace Core.Shared;

public abstract class DatabaseContext : DbContext
{
  protected abstract override void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
}