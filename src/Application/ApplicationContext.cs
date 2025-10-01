using Core;
using Core.Shared;
using Domain.Blog;
using Domain.Posts;
using Microsoft.EntityFrameworkCore;

namespace Application;

public abstract class ApplicationContext : DatabaseContext
{
  public ApplicationContext()
  {
    LoadEnv.Run();
  }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }
}