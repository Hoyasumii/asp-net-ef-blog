using System.ComponentModel.DataAnnotations;
using Domain.Posts;
using Core;

namespace Domain.Blog;

public class Blog : Entity
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Vai se foder filho da puta")]
  [Url(ErrorMessage = "O campo precisa ser uma URL")]
  public required string Url { get; init; }
  public List<Post> Posts { get; } = [];
}
