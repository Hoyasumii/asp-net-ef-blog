using Application.Posts;
using Domain.Posts;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Posts;

public class MakeUpdatePostByIdFactory
{
  public static UpdatePostByIdService Run()
  {
    IPostRepository<IApplicationContext> repository = MakePostRepository.Run();

    UpdatePostByIdService service = new(repository);

    return service;
  }
}