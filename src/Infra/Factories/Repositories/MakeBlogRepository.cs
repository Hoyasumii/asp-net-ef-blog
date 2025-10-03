using Domain.Blogs;
using Infra.Built;
using Infra.Interfaces;
using Infra.Repositories;

namespace Infra.Factories.Repositories;

public class MakeBlogRepository
{
  public static IBlogRepository<IApplicationContext> Run()
  {
    ApplicationContext context = new();
    return new BlogRepository(context);
  }
}