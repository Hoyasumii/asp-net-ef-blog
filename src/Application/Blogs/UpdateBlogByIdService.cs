using Application.Shared.Exceptions;
using Core.Interfaces;
using Core.Validators;
using Domain.Blogs;
using Domain.Blogs.Dtos;

namespace Application.Blogs;

public class UpdateBlogByIdService(IBlogRepository<IDatabaseContext> repository) : IService<IBlogRepository<IDatabaseContext>, UpdateBlogDTO, Blog>
{
  public IBlogRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Blog> Run(UpdateBlogDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Blog");
    }

    Blog targetBlog = await Repository.UpdateById(data) ?? throw new ResourceNotFoundException("Blog");

    return targetBlog;
  }
}