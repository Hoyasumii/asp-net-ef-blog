using Domain.Blogs;
using Infra.Abstractions;
using Infra.Interfaces;

namespace Infra.Repositories.Blogs;

public class CreateBlog(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : BlogActionMethods<Blog, Task<Blog>>(context, repository)
{
  public override async Task<Blog> Method(Blog content)
  {
    await Context.Blogs.AddAsync(content);

    await Context.Save();

    return content;
  }
}
