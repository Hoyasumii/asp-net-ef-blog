namespace Domain.Shared;

using Core.Shared;

public sealed class DTOValidator(IDTO dto) : SchemaValidator<IDTO>(dto)
{

}