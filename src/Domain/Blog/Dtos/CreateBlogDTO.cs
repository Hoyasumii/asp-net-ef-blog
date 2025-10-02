using System.ComponentModel.DataAnnotations;
using Core.Interfaces;
namespace Domain.Blog.Dtos;

public class CreateBlogDTO: IDataTransferObject
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Não é Possível criar um Blog com a Url não Definida")]
  [Url(ErrorMessage = "Não é Possível criar um Blog com a Url Inválida")]
  public required string Url { get; init; }
}
