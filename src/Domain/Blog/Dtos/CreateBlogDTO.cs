using System.ComponentModel.DataAnnotations;
namespace Domain.Blog.Dtos;

public class CreateBlogDTO
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Não é Possível criar um Blog com a Url não Definida")]
  [Url(ErrorMessage = "Não é Possível criar um Blog com a Url Inválida")]
  public required string Url { get; init; }
}
