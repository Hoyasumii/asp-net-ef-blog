using Domain.Blogs;
using Test.Built;
using Infra.Interfaces;
using Infra.Repositories.EntityFrameworkCore;

namespace Test.Factories.Repositories;

public class MakeBlogRepository
{
  public static IBlogRepository<IEntityFrameworkCoreAsORMContext> Run()
  {
    ApplicationContext context = new();
    return new BlogRepository(context);
  }
}