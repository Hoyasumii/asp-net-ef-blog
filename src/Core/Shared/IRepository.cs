namespace Core.Shared;

public interface IRepository<EntityType> where EntityType : Entity
{
  RepositoryProvider<EntityType> Provider { get; }

  Task<EntityType> Create(EntityType content);
  Task<EntityType?> FindById(string id);
  Task<EntityType?> UpdateById(string id);
  Task<bool> DeleteById(string id);
}