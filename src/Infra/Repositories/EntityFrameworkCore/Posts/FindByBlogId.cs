using Domain.Posts;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.EntityFrameworkCore.Posts;

public class FindByBlogId(IApplicationContext context, IPostRepository<IApplicationContext> repository) : PostActionMethods<string, Task<Post[]?>>(context, repository) {
  public override async Task<Post[]?> Method(string arg)
  {
    var targetPosts = await Context.Posts
                      .Where(Post => Post.BlogId.ToString() == arg)
                      .ToListAsync();

    if (targetPosts.Count == 0) return null;

    return [.. targetPosts];
  }
}