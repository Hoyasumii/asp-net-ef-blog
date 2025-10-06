using Domain.Blogs;
using Infra.Built;
using Infra.Interfaces;
using Infra.Repositories.EntityFrameworkCore;

namespace Infra.Factories.Repositories;

public class MakeBlogRepository
{
  public static IBlogRepository<IEntityFrameworkCoreAsORMContext> Run()
  {
    EntityFrameworkCoreAsORMContext context = new();
    return new BlogRepository(context);
  }
}