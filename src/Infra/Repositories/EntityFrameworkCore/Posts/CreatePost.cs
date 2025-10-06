using Domain.Posts;
using Infra.Abstractions;
using Infra.Interfaces;

namespace Infra.Repositories.EntityFrameworkCore.Posts;

public class CreatePost(IEntityFrameworkCoreAsORMContext context, IPostRepository<IEntityFrameworkCoreAsORMContext> repository) : PostActionMethods<Post, Task<Post>>(context, repository)
{
  public override async Task<Post> Method(Post content)
  {
    await Context.Posts.AddAsync(content);

    await Context.Save();

    return content;
  }
}