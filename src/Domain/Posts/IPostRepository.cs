using Core.Interfaces;
using Domain.Posts.Dtos;

namespace Domain.Posts;

public interface IPostRepository<out Context> : IRepository<Context> where Context : IDatabaseContext
{
  public Func<Post, Task<Post>> Create { get; }
  public Func<string, Task<Post?>> FindById { get; }
  public Func<string, Task<Post[]?>> FindByBlogId { get; }
  public Func<UpdatePostDTO, Task<Post?>> UpdateById { get; }
  public Func<string, Task<bool>> DeleteById { get; }
}