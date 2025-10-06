using Domain.Posts;
using Infra.Built;
using Infra.Interfaces;
using Infra.Repositories.EntityFrameworkCore;

namespace Infra.Factories.Repositories;

public class MakePostRepository
{
  public static IPostRepository<IApplicationContext> Run()
  {
    ApplicationContext context = new();
    return new PostRepository(context);
  }
}