using Domain.Posts;
using Infra.Abstractions;
using Infra.Interfaces;

namespace Infra.Repositories.Posts;

public class CreatePost(IApplicationContext context, IPostRepository<IApplicationContext> repository) : PostActionMethods<Post, Task<Post>>(context, repository)
{
  public override async Task<Post> Method(Post content)
  {
    await Context.Posts.AddAsync(content);

    await Context.Save();

    return content;
  }
}