using Domain.Posts;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.EntityFrameworkCore.Posts;

public class DeleteById(IApplicationContext context, IPostRepository<IApplicationContext> repository) : PostActionMethods<string, Task<bool>>(context, repository)
{
  public override async Task<bool> Method(string arg)
  {
    var targetPost = await Context.Posts.FirstOrDefaultAsync(Post => Post.Id.ToString() == arg);

    if (targetPost is null) return false;

    Context.Posts.Remove(targetPost);

    await Context.Save();

    return true;
  }
}