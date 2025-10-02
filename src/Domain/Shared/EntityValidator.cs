using Core.Shared;

namespace Domain.Shared;

public sealed class EntityValidator(Entity entity) : SchemaValidator<Entity>(entity)
{

}