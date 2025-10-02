using Microsoft.EntityFrameworkCore;

namespace Core.Shared;

public abstract class Repository<EntityType, ContextType>(ContextType context) where EntityType : Entity where ContextType : DatabaseContext
{
  protected ContextType Context { get; } = context;
}