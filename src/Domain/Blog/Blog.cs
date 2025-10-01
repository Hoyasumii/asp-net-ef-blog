using System.ComponentModel.DataAnnotations;
using Domain.Posts;
using Core.Shared;

namespace Domain.Blog;

public class Blog : Entity
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Vai se foder filho da puta")]
  [Url(ErrorMessage = "O campo precisa ser uma URL")]
  public required string Url { get; init; }
  [Required(AllowEmptyStrings = false)]
  [EmailAddress]
  public required string Email { get; init; }
  public List<Post> Posts { get; } = [];
}
