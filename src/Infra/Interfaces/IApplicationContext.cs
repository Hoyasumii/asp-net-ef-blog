using Core.Interfaces;
using Domain.Blog;
using Domain.Posts;
using Microsoft.EntityFrameworkCore;

namespace Infra.Interfaces;

public interface IApplicationContext : IDatabaseContext
{
  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }
}