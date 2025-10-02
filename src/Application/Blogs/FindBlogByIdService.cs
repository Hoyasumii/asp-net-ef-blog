using Application.Exceptions;
using Core.Dtos;
using Core.Interfaces;
using Core.Validators;
using Domain.Blogs;

namespace Application.Blogs;

public class FindBlogByIdService(IBlogRepository<IDatabaseContext> repository) : IService<IBlogRepository<IDatabaseContext>, GuidDTO, Blog>
{
  public IBlogRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Blog> Run(GuidDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Blog");
    }

    Blog targetBlog = await Repository.FindById(data.Id.ToString()) ?? throw new ResourceNotFoundException("Blog");

    return targetBlog;
  }
}