using Domain.Blogs;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.EntityFrameworkCore.Blogs;

public class FindById(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : BlogActionMethods<string, Task<Blog?>>(context, repository)
{
  public override async Task<Blog?> Method(string arg)
  {
    return await Context.Blogs.FirstOrDefaultAsync(Blog => Blog.Id.ToString() == arg);
  }
}