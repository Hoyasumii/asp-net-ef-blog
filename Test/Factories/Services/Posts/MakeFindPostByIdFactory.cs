using Application.Posts;
using Domain.Posts;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Posts;

public class MakeFindPostByIdFactory
{
  public static FindPostByIdService Run()
  {
    IPostRepository<IApplicationContext> repository = MakePostRepository.Run();

    FindPostByIdService service = new(repository);

    return service;
  }
}