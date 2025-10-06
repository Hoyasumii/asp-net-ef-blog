using Application.Blogs;
using Domain.Blogs;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Blogs;

public class MakeCreateBlogFactory
{
  public static CreateBlogService Run()
  {
    IBlogRepository<IEntityFrameworkCoreAsORMContext> repository = MakeBlogRepository.Run();

    CreateBlogService service = new(repository);

    return service;
  }
}