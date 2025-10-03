using Core.Dtos;
using Core.Interfaces;
using Domain.Blogs.Dtos;

namespace Domain.Blogs;

public interface IBlogRepository<out Context> : IRepository<Context> 
  where Context : IDatabaseContext
{
  public Func<Blog, Task<Blog>> Create { get; }
  public Func<string, Task<Blog?>> FindById { get; }
  public Func<UpdateBlogDTO, Task<Blog?>> UpdateById { get; }
  public Func<string, Task<bool>> DeleteById { get; }
}
