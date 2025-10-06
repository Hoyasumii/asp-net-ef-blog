using Domain.Posts;
using Domain.Posts.Dtos;
using Infra.Abstractions;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.EntityFrameworkCore.Posts;

public class UpdateById(IApplicationContext context, IPostRepository<IApplicationContext> repository) : PostActionMethods<UpdatePostDTO, Task<Post?>>(context, repository)
{
  public override async Task<Post?> Method(UpdatePostDTO arg)
  {
    var targetPost = await Context.Posts.FirstOrDefaultAsync(Post =>
      Post.Id == arg.Id);

    if (targetPost is null) return null;

    targetPost.Title = arg.Title;
    targetPost.Content = arg.Content;
    targetPost.BlogId = arg.BlogId;

    var newBlogReference = await Context.Blogs.FindAsync(arg.BlogId);

    if (newBlogReference is null) return null;

    targetPost.Blog = newBlogReference;

    await Context.Save();

    return targetPost;
  }
}