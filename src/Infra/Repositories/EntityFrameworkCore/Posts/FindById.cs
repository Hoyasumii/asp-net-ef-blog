using Domain.Posts;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.EntityFrameworkCore.Posts;

public class FindById(IEntityFrameworkCoreAsORMContext context, IPostRepository<IEntityFrameworkCoreAsORMContext> repository) : PostActionMethods<string, Task<Post?>>(context, repository)
{
  public override async Task<Post?> Method(string arg)
  {
    return await Context.Posts.FirstOrDefaultAsync(Blog => Blog.Id.ToString() == arg);
  }
}