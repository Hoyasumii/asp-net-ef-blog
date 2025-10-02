using Microsoft.EntityFrameworkCore;

namespace Core.Shared;

public abstract class Repository<EntityType, ContextType>(ContextType context) where EntityType : Entity where ContextType : DatabaseContext
{
  protected ContextType Context { get; } = context;

  public abstract Task<EntityType> Create<ArgumentType>(ArgumentType content) where ArgumentType : class;
  public abstract Task<EntityType?> FindById(string id);
  public abstract Task<EntityType?> UpdateById<ArgumentType>(string id, ArgumentType data) where ArgumentType : class;
  public abstract Task<bool> DeleteById(string id);
}