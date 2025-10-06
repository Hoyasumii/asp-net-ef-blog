using Application.Posts;
using Domain.Posts;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Posts;

public class MakeDeletePostByIdFactory
{
  public static DeletePostByIdService Run()
  {
    IPostRepository<IApplicationContext> repository = MakePostRepository.Run();

    DeletePostByIdService service = new(repository);

    return service;
  }
}