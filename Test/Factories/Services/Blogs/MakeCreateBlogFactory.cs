using Application.Blogs;
using Domain.Blogs;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Blogs;

public class MakeCreateBlogFactory
{
  public static CreateBlogService Run()
  {
    IBlogRepository<IApplicationContext> repository = MakeBlogRepository.Run();

    CreateBlogService service = new(repository);

    return service;
  }
}