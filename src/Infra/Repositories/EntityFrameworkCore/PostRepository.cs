using Domain.Posts;
using Domain.Posts.Dtos;
using Infra.Interfaces;
using Infra.Repositories.EntityFrameworkCore.Posts;

namespace Infra.Repositories.EntityFrameworkCore;

public class PostRepository : IPostRepository<IApplicationContext>
{
  public IApplicationContext Context { get; }
  public Func<Post, Task<Post>> Create { get; }
  public Func<string, Task<Post?>> FindById { get; }
  public Func<string, Task<Post[]?>> FindByBlogId { get; }
  public Func<UpdatePostDTO, Task<Post?>> UpdateById { get; }
  public Func<string, Task<bool>> DeleteById { get; }

  public PostRepository(IApplicationContext context)
  {
    Context = context;
    Create = new CreatePost(context, this).Method;
    FindById = new FindById(context, this).Method;
    FindByBlogId = new FindByBlogId(context, this).Method;
    UpdateById = new UpdateById(context, this).Method;
    DeleteById = new DeleteById(context, this).Method;
  }
}