namespace Domain.Shared;

using Core.Interfaces;

public sealed class DTOValidator(IDataTransferObject dto) : SchemaValidator<IDataTransferObject>(dto)
{

}