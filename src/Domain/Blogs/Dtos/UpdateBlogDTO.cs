using System.ComponentModel.DataAnnotations;
using Core.Interfaces;
using Core.Annotations;

namespace Domain.Blogs.Dtos;

public class UpdateBlogDTO: IDataTransferObject
{
  [Required(AllowEmptyStrings = false)]
  [GuidAnnotation()]
  public required Guid Id { get; init; }
  
  [Required(AllowEmptyStrings = false, ErrorMessage = "Não é Possível criar um Blog com a Url não Definida")]
  [Url(ErrorMessage = "Não é Possível criar um Blog com a Url Inválida")]
  public required string Url { get; init; }
}