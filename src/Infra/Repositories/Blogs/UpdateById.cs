using Domain.Blogs;
using Domain.Blogs.Dtos;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.Blogs;

public class UpdateById(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : BlogActionMethods<UpdateBlogDTO, Task<Blog?>>(context, repository)
{
  public override async Task<Blog?> Method(UpdateBlogDTO arg)
  {
    Blog? targetBlog = await Context.Blogs.FirstOrDefaultAsync(Blog =>
      Blog.Id == arg.Id);

    if (targetBlog is null) return null;

    targetBlog.Id = arg.Id;
    targetBlog.Url = arg.Url;

    await Context.Save();

    return targetBlog;
  }
}