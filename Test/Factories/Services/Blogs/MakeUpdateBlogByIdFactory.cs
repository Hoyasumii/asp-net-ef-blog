using Application.Blogs;
using Domain.Blogs;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Blogs;

public class MakeUpdateBlogByIdFactory
{
  public static UpdateBlogByIdService Run()
  {
    IBlogRepository<IEntityFrameworkCoreAsORMContext> repository = MakeBlogRepository.Run();

    UpdateBlogByIdService service = new(repository);

    return service;
  }
}
