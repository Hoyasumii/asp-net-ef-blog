namespace Core.Shared;

public abstract class Entity
{
  public string Id { get; private set; } = Guid.NewGuid().ToString();
  public DateTime CreatedAt { get; private set; } = DateTime.Now;
}

