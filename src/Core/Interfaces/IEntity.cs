namespace Core.Interfaces;

public interface IEntity
{
  public string Id { get; protected set; }
  public DateTime CreatedAt { get; protected set; }
}