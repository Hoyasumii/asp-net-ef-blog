using System.ComponentModel.DataAnnotations;
using Domain.Shared;

namespace Core;

public class EntityValidation<EntityType>(EntityType entity) where EntityType : Entity
{
  private ValidationContext Context { get; } = new(entity);
  public List<ValidationResult> Results { get; } = [];
  public bool IsValid
  {
    get => Validator.TryValidateObject(entity, Context, Results, true);
  }
}