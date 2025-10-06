using Application.Blogs;
using Domain.Blogs;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Blogs;

public class MakeFindBlogByIdFactory
{
  public static FindBlogByIdService Run()
  {
    var repository = MakeBlogRepository.Run();

    FindBlogByIdService service = new(repository);

    return service;
  }
}
