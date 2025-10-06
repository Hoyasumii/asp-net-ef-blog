using Application.Shared.Exceptions;
using Core.Dtos;
using Core.Interfaces;
using Core.Validators;
using Domain.Posts;

public class FindPostsByBlogIdService(IPostRepository<IDatabaseContext> repository) : IService<IPostRepository<IDatabaseContext>, GuidDTO, Post[]>
{
  public IPostRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Post[]> Run(GuidDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Post");
    }

    var targetPosts = await Repository.FindByBlogId(data.Id.ToString()) ?? throw new ResourceNotFoundException($"Task {data.Id}");

    return targetPosts;
  }
}