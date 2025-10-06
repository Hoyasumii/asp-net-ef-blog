using Application.Shared.Exceptions;
using Core.Dtos;
using Core.Interfaces;
using Core.Validators;
using Domain.Posts;

namespace Application.Posts;

public sealed class DeletePostByIdService(IPostRepository<IDatabaseContext> repository) : IService<IPostRepository<IDatabaseContext>, GuidDTO, bool>
{
  private IPostRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<bool> Run(GuidDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Post");
    }

    var wasDeleted = await Repository.DeleteById(data.Id.ToString());

    if (!wasDeleted)
    {
      throw new ResourceNotFoundException("Post");
    }

    return wasDeleted;
  }
}
