using Application.Shared.Exceptions;
using Core.Interfaces;
using Core.Validators;
using Domain.Blogs;
using Domain.Blogs.Dtos;

namespace Application.Blogs;

public class CreateBlogService(IBlogRepository<IDatabaseContext> repository) : IService<IBlogRepository<IDatabaseContext>, CreateBlogDTO, Blog>
{
  public IBlogRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Blog> Run(CreateBlogDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Blog");
    }

    Blog newEntity = new()
    {
      Url = data.Url
    };

    return await Repository.Create(newEntity);
  }
}