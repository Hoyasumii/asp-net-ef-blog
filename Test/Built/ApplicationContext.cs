using Domain.Blogs;
using Domain.Posts;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Test.Built;

public class ApplicationContext : DbContext, IApplicationContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // Use a unique name for the in-memory database for each test run to ensure isolation
    optionsBuilder.UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString());
  }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }

  public async Task<int> Save() => await SaveChangesAsync();
}