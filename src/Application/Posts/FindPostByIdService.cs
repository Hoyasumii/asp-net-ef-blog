using Application.Shared.Exceptions;
using Core.Dtos;
using Core.Interfaces;
using Core.Validators;
using Domain.Posts;

namespace Application.Posts;

public sealed class FindPostByIdService(IPostRepository<IDatabaseContext> repository) : IService<IPostRepository<IDatabaseContext>, GuidDTO, Post>
{
  private IPostRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Post> Run(GuidDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Post");
    }

    var targetPost =
    await Repository.FindById(data.Id.ToString())
    ?? throw new ResourceNotFoundException("Post");

    return targetPost;
  }
}