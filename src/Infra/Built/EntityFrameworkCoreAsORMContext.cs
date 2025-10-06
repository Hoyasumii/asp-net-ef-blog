using Domain.Blogs;
using Domain.Posts;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Built;

public class EntityFrameworkCoreAsORMContext : DbContext, IEntityFrameworkCoreAsORMContext
{
  public EntityFrameworkCoreAsORMContext()
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