using Core.Shared;
using System.ComponentModel.DataAnnotations;

namespace Domain.Shared;

public class EntityValidator<EntityType>(EntityType entity) where EntityType : Entity
{
  private ValidationContext Context { get; } = new(entity);
  public List<ValidationResult> Results { get; } = [];
  public bool IsValid
  {
    get => Validator.TryValidateObject(entity, Context, Results, true);
  }
}