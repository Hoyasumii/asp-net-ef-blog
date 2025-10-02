using Application.Exceptions;
using Core.Interfaces;
using Core.Validators;
using Domain.Blogs;
using Domain.Blogs.Dtos;

namespace Application.Blogs;

public class CreateBlogService<RepositoryType>(RepositoryType repository) : IService<RepositoryType, CreateBlogDTO, Blog>
  where RepositoryType : IBlogRepository<IDatabaseContext>
{
  public RepositoryType Repository { get; } = repository;

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