namespace Core.Interfaces;

public interface IRepository<out DatabaseContextType> where DatabaseContextType : IDatabaseContext
{
  public DatabaseContextType Context { get; }
}