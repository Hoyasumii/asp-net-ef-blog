using Core.Interfaces;

namespace Domain.Shared;

public sealed class EntityValidator(IEntity entity) : SchemaValidator<IEntity>(entity)
{

}