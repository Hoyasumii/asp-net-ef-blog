using Core.Interfaces;
using Core.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Core.Dtos;

public class GuidDTO : IDataTransferObject
{
  [Required(AllowEmptyStrings = false)]
  [GuidAnnotation()]
  public required Guid Id { get; init; }
}