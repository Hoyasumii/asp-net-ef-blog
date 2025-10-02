using Core.Interfaces;
using Domain.Blogs;
using Domain.Blogs.Dtos;

namespace Application.Blogs;

public class CreateBlogService(IBlogRepository<IDatabaseContext> repository) : IService<IBlogRepository<IDatabaseContext>, CreateBlogDTO, Blog>
{
  public IBlogRepository<IDatabaseContext> Repository { get; } = repository;

  public Task<Blog> Run(CreateBlogDTO data)
  {
    throw new NotImplementedException();
  }
}