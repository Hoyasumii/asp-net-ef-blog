namespace Core.Validators;

using Core.Interfaces;

public sealed class DTOValidator(IDataTransferObject dto) : SchemaValidator<IDataTransferObject>(dto)
{

}