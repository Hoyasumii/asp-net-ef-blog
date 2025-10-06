using Application.Posts;
using Domain.Posts;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Posts;

public class MakeFindPostsByBlogIdFactory
{
  public static FindPostsByBlogIdService Run()
  {
    IPostRepository<IApplicationContext> repository = MakePostRepository.Run();

    FindPostsByBlogIdService service = new(repository);

    return service;
  }
}