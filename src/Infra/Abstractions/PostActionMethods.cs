using Domain.Posts;
using Infra.Interfaces;

namespace Infra.Abstractions;

public abstract class PostActionMethods<Input, Output>(IApplicationContext context, IPostRepository<IApplicationContext> repository) : IPostActionMethods<Input, Output>
{
  public IApplicationContext Context { get; } = context;
  public IPostRepository<IApplicationContext> Repository { get; } = repository;

  public abstract Output Method(Input content);
}