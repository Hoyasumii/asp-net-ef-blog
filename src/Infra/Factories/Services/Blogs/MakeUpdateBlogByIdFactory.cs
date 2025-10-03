using Application.Blogs;
using Domain.Blogs;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Blogs;

public class MakeUpdateBlogByIdFactory
{
  public static UpdateBlogByIdService Run()
  {
    IBlogRepository<IApplicationContext> repository = MakeBlogRepository.Run();

    UpdateBlogByIdService service = new(repository);

    return service;
  }
}
