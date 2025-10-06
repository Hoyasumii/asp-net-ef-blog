using Application.Posts;
using Domain.Posts;
using Infra.Factories.Repositories;
using Infra.Interfaces;

namespace Infra.Factories.Services.Posts;

public class MakeCreatePostFactory
{
  public static CreatePostService Run()
  {
    var repository = MakePostRepository.Run();

    CreatePostService service = new(repository);

    return service;
  }
}
