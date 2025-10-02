namespace Core.Interfaces;

public interface IRepository<DatabaseContextType> where DatabaseContextType : IDatabaseContext
{
  public DatabaseContextType Context { get; }
}