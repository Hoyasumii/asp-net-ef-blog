
using Application.Shared.Exceptions;
using Core.Interfaces;
using Core.Validators;
using Domain.Posts;
using Domain.Posts.Dtos;

namespace Application.Posts;

public sealed class UpdatePostByIdService(IPostRepository<IDatabaseContext> repository) : IService<IPostRepository<IDatabaseContext>, UpdatePostDTO, Post>
{
  private IPostRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Post> Run(UpdatePostDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Post");
    }

    var updatedPost = new Post
    {
      BlogId = data.Id,
      Content = data.Content,
      Title = data.Title
    };

    var targetPost =
    await Repository.UpdateById(data)
    ?? throw new ResourceNotFoundException("Post");

    return targetPost;
  }
}
