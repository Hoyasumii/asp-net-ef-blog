namespace Core.Interfaces;

public interface IActionMethods<out RepositoryType, out ContextType, in Args, out Output>: IInjectableRepository<RepositoryType, ContextType> where ContextType : IDatabaseContext where RepositoryType : IRepository<ContextType>
{
  public Output Method(Args content);
}