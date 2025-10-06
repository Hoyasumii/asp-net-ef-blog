using Domain.Blogs;
using Infra.Abstractions;
using Infra.Interfaces;

namespace Infra.Repositories.EntityFrameworkCore.Blogs;

public class CreateBlog(IEntityFrameworkCoreAsORMContext context, IBlogRepository<IEntityFrameworkCoreAsORMContext> repository) : BlogActionMethods<Blog, Task<Blog>>(context, repository)
{
  public override async Task<Blog> Method(Blog content)
  {
    await Context.Blogs.AddAsync(content);

    await Context.Save();

    return content;
  }
}
