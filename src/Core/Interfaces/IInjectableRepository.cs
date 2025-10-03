namespace Core.Interfaces;

public interface IInjectableRepository<out RepositoryType, out ContextType> where RepositoryType : IRepository<ContextType> where ContextType : IDatabaseContext
{
  public ContextType Context { get; }
  public RepositoryType Repository { get; }  
}