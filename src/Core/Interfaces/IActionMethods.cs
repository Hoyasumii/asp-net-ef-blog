namespace Core.Interfaces;

public interface IActionMethods<out RepositoryType, out ContextType, in Args, out Output> where ContextType : IDatabaseContext where RepositoryType : IRepository<ContextType>
{
  public ContextType Context { get; }
  public RepositoryType Repository { get; }

  public Output Method(Args content);
}