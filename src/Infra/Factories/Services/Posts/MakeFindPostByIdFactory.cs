using Application.Posts;
using Domain.Posts;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Posts;

public class MakeFindPostByIdFactory
{
  public static FindPostByIdService Run()
  {
    var repository = MakePostRepository.Run();

    FindPostByIdService service = new(repository);

    return service;
  }
}
