using Core.Interfaces;
using Domain.Blog;
using Domain.Posts;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Built;

public class ApplicationContext : DbContext, IApplicationContext
{
  public ApplicationContext()
  {
    LoadEnv.Run();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
  }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }

  public async Task<int> Save() => await SaveChangesAsync();
 
}