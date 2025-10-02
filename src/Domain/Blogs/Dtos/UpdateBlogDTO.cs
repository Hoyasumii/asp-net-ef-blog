using System.ComponentModel.DataAnnotations;
using Core.Interfaces;

namespace Domain.Blogs.Dtos;

public class UpdateBlogDTO: IDataTransferObject
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Não é Possível criar um Blog com a Url não Definida")]
  [Url(ErrorMessage = "Não é Possível criar um Blog com a Url Inválida")]
  public required string Url { get; init; }
}