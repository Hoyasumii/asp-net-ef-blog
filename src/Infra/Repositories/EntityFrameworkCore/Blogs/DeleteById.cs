using Core.Dtos;
using Domain.Blogs;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.Blogs;

public class DeleteById(IEntityFrameworkCoreAsORMContext context, IBlogRepository<IEntityFrameworkCoreAsORMContext> repository) : BlogActionMethods<string, Task<bool>>(context, repository)
{
  public override async Task<bool> Method(string arg)
  {
    Blog? targetBlog = await Context.Blogs.FirstOrDefaultAsync(Blog => Blog.Id.ToString() == arg);

    if (targetBlog is null) return false;

    Context.Blogs.Remove(targetBlog);

    await Context.Save();

    return true;
  }
}