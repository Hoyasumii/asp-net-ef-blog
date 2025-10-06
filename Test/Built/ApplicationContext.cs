using Domain.Blogs;
using Domain.Posts;
using Infra.Interfaces;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Test.Built;

public class ApplicationContext : DbContext, IApplicationContext
{
  private readonly SqliteConnection _connection;

  public ApplicationContext()
  {
    _connection = new("DataSource=:memory:");
    _connection.Open();
    Database.EnsureCreated();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite(_connection);
  }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }

  public async Task<int> Save() => await SaveChangesAsync();

  public override void Dispose()
  {
    _connection.Close();
    base.Dispose();
  }
}