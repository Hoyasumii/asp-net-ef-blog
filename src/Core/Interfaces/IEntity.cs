namespace Core.Interfaces;

public interface IEntity
{
  public Guid Id { get; protected set; }
  public DateTime CreatedAt { get; protected set; }
}
