namespace Core.Interfaces;

public interface IRepository<out DatabaseContextType> where DatabaseContextType : IDatabaseContext
{
  protected DatabaseContextType Context { get; }
}