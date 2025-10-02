using Core.Interfaces;

namespace Core.Validators;

public sealed class EntityValidator(IEntity entity) : SchemaValidator<IEntity>(entity)
{

}