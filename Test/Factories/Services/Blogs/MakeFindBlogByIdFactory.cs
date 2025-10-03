using Application.Blogs;
using Domain.Blogs;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Blogs;

public class MakeFindBlogByIdFactory
{
  public static FindBlogByIdService Run()
  {
    IBlogRepository<IApplicationContext> repository = MakeBlogRepository.Run();

    FindBlogByIdService service = new(repository);

    return service;
  }
}
