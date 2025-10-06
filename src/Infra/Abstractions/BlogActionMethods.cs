using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Abstractions;

public abstract class BlogActionMethods<Input, Output>(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : IBlogActionMethods<Input, Output>
{
  public IApplicationContext Context { get; } = context;
  public IBlogRepository<IApplicationContext> Repository { get; } = repository;

  public abstract Output Method(Input content);
}