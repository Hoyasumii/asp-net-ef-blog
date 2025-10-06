using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Abstractions;

public abstract class BlogActionMethods<Input, Output>(IEntityFrameworkCoreAsORMContext context, IBlogRepository<IEntityFrameworkCoreAsORMContext> repository) : IBlogActionMethods<Input, Output>
{
  public IEntityFrameworkCoreAsORMContext Context { get; } = context;
  public IBlogRepository<IEntityFrameworkCoreAsORMContext> Repository { get; } = repository;

  public abstract Output Method(Input content);
}