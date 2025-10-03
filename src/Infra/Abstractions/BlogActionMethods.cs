using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Abstractions;

public abstract class BlogActionMethods(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : IBlogActionMethods<Blog, Task<Blog>>
{
  public IApplicationContext Context { get; } = context;
  public IBlogRepository<IApplicationContext> Repository { get; } = repository;

  public abstract Task<Blog> Method(Blog content);
}