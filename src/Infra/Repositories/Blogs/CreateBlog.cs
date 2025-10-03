using Core.Interfaces;
using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Repositories.Blogs;

public class CreateBlog<ContextType>(ContextType context, IBlogRepository<ContextType> repository) : IActionMethods<IBlogRepository<ContextType>, ContextType, Blog, Task<Blog>> where ContextType : IApplicationContext
{
  public ContextType Context { get; } = context;
  public IBlogRepository<ContextType> Repository { get; } = repository;

  public async Task<Blog> Method(Blog content)
  {
    await Context.Blogs.AddAsync(content);

    await Context.Save();

    return content;
  }
}
