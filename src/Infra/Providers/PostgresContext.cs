namespace Infra.Providers;

using Application;
using Core;
using Microsoft.EntityFrameworkCore;

public class PostgresContext : ApplicationContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
  }
}