using System.ComponentModel.DataAnnotations;
using Core.Interfaces;
using Core.Annotations;

namespace Domain.Posts.Dtos;

public class CreatePostDTO : IDataTransferObject
{
  [Required(AllowEmptyStrings = false)]
  [MinLength(4)]
  [DataType(dataType: DataType.Text)]
  public required string Title { get; init; }

  [Required(AllowEmptyStrings = false)]
  [MinLength(4)]
  [DataType(dataType: DataType.Text)]
  public required string Content { get; init; }

  [Required(AllowEmptyStrings = false)]
  [GuidAnnotation()]
  public required Guid BlogId { get; init; }

}