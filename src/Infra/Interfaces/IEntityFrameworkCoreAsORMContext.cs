using Core.Interfaces;
using Domain.Blogs;
using Domain.Posts;
using Microsoft.EntityFrameworkCore;

namespace Infra.Interfaces;

public interface IEntityFrameworkCoreAsORMContext : IDatabaseContext
{
  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }
}