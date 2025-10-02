using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Repositories.Blogs;

// Action Methods
public class CreateBlog(IApplicationContext context)
{
  protected IApplicationContext Context { get; } = context;

  protected async Task<Blog> Create(Blog content)
  {
    await Context.Blogs.AddAsync(content);

    await Context.Save();

    return content;
  }


  public static Func<Blog, Task<Blog>> Run(IApplicationContext context)
  {
    return new CreateBlog(context).Create;
  }


}