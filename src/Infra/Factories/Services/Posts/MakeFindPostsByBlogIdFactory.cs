using Application.Posts;
using Domain.Posts;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Posts;

public class MakeFindPostsByBlogIdFactory
{
  public static FindPostsByBlogIdService Run()
  {
    var repository = MakePostRepository.Run();

    FindPostsByBlogIdService service = new(repository);

    return service;
  }
}
