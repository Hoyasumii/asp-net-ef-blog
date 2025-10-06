using Domain.Posts;
using Test.Built;
using Infra.Interfaces;
using Infra.Repositories.EntityFrameworkCore;

namespace Test.Factories.Repositories;

public class MakePostRepository
{
  public static IPostRepository<IApplicationContext> Run()
  {
    ApplicationContext context = new();
    return new PostRepository(context);
  }
}