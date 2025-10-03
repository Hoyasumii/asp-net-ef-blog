using Domain.Blogs;
using Test.Built;
using Infra.Interfaces;
using Infra.Repositories;

namespace Test.Factories.Repositories;

public class MakeBlogRepository
{
  public static IBlogRepository<IApplicationContext> Run()
  {
    ApplicationContext context = new();
    return new BlogRepository(context);
  }
}