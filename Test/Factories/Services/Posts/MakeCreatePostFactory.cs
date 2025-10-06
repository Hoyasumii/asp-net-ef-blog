using Application.Posts;
using Domain.Posts;
using Test.Factories.Repositories;
using Infra.Interfaces;

namespace Test.Factories.Services.Posts;

public class MakeCreatePostFactory
{
  public static CreatePostService Run()
  {
    IPostRepository<IApplicationContext> repository = MakePostRepository.Run();

    CreatePostService service = new(repository);

    return service;
  }
}