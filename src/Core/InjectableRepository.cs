using Core.Interfaces;

namespace Core;

public abstract class InjectableRepository<RepositoryType, ContextType>(RepositoryType repository, ContextType context) : IInjectableRepository<RepositoryType, ContextType> where RepositoryType : IRepository<ContextType> where ContextType : IDatabaseContext
{
  public RepositoryType Repository { get; } = repository;
  public ContextType Context { get; } = context;
}