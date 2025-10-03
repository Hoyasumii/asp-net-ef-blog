using Application.Shared.Exceptions;
using Core.Dtos;
using Core.Interfaces;
using Core.Validators;
using Domain.Blogs;
using Domain.Blogs.Dtos;

namespace Application.Blogs;

public class DeleteBlogByIdService(IBlogRepository<IDatabaseContext> repository) : IService<IBlogRepository<IDatabaseContext>, GuidDTO, bool>
{
  public IBlogRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<bool> Run(GuidDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Blog");
    }

    return await Repository.DeleteById(data.Id.ToString());
  }
}