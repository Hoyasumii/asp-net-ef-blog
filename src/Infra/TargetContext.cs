namespace Infra;

using Application;
using Microsoft.EntityFrameworkCore;

public class TargetContext : ApplicationContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
  }
}