namespace Infra.Providers;

using Core.Shared;
using Microsoft.EntityFrameworkCore;

public class PostgresProvider<EntityType> : RepositoryProvider<EntityType> where EntityType : Entity
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
  }
}