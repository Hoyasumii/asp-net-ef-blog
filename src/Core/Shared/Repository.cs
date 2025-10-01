using Microsoft.EntityFrameworkCore;

namespace Core.Shared;

public abstract class Repository<EntityType, ContextType>(ContextType context) where EntityType : Entity where ContextType : DatabaseContext
{
  protected ContextType Context { get; } = context;

  public abstract Task<EntityType> Create(EntityType content);
  public abstract Task<EntityType?> FindById(string id);
  public abstract Task<EntityType?> UpdateById(string id);
  public abstract Task<bool> DeleteById(string id);
}