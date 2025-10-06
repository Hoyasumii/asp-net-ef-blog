using Application.Posts;
using Domain.Posts;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Posts;

public class MakeDeletePostByIdFactory
{
  public static DeletePostByIdService Run()
  {
    var repository = MakePostRepository.Run();

    DeletePostByIdService service = new(repository);

    return service;
  }
}
