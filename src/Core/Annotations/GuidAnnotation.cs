using System.ComponentModel.DataAnnotations;

namespace Core.Annotations;

public class GuidAnnotation : ValidationAttribute
{
  public GuidAnnotation()
  {
    ErrorMessage = "O campo {0} é obrigatório e não pode ser um Guid vazio.";
  }

  public override bool IsValid(object? value)
  {
    if (value is null)
    {
      return false;
    }

    if (value is Guid guidValue)
    {
      return guidValue != Guid.Empty;
    }

    return false;
  }
}