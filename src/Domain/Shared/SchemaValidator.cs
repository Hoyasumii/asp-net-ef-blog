namespace Domain.Shared;

using System.ComponentModel.DataAnnotations;

public abstract class SchemaValidator<SchemaType>(SchemaType schema) where SchemaType : class
{
  private ValidationContext Context { get; } = new(schema);
  public List<ValidationResult> Results { get; } = [];
  public bool IsValid
  {
    get => Validator.TryValidateObject(schema, Context, Results, true);
  }
}