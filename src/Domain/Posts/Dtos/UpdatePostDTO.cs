using System.ComponentModel.DataAnnotations;
using Core.Annotations;

namespace Domain.Posts.Dtos;

public class UpdatePostDTO : CreatePostDTO
{
  [Required(AllowEmptyStrings = false)]
  [GuidAnnotation()]
  public required Guid Id { get; init; }
}