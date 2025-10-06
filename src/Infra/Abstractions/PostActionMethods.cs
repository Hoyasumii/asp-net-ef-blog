using Domain.Posts;
using Infra.Interfaces;

namespace Infra.Abstractions;

public abstract class PostActionMethods<Input, Output>(IEntityFrameworkCoreAsORMContext context, IPostRepository<IEntityFrameworkCoreAsORMContext> repository) : IPostActionMethods<Input, Output>
{
  public IEntityFrameworkCoreAsORMContext Context { get; } = context;
  public IPostRepository<IEntityFrameworkCoreAsORMContext> Repository { get; } = repository;

  public abstract Output Method(Input content);
}