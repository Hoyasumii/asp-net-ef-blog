using Core.Interfaces;

namespace Core;

public abstract class Entity: IEntity
{
  public string Id { get; set; } = Guid.NewGuid().ToString();
  public DateTime CreatedAt { get; set; } = DateTime.Now;
}
