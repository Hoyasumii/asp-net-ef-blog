namespace Domain.Shared;

public abstract class Entity(DateTime? createdAt)
{
  public string Id { get; } = Guid.NewGuid().ToString();
  public DateTime CreatedAt { get; } = createdAt ?? DateTime.Now;
}

