using Application.Posts;
using Domain.Posts;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Posts;

public class MakeUpdatePostByIdFactory
{
  public static UpdatePostByIdService Run()
  {
    var repository = MakePostRepository.Run();

    UpdatePostByIdService service = new(repository);

    return service;
  }
}
