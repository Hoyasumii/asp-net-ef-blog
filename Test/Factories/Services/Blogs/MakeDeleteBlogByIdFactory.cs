using Application.Blogs;
using Domain.Blogs;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Blogs;

public class MakeDeleteBlogByIdFactory
{
  public static DeleteBlogByIdService Run()
  {
    IBlogRepository<IApplicationContext> repository = MakeBlogRepository.Run();

    DeleteBlogByIdService service = new(repository);

    return service;
  }
}
