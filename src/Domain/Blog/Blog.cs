using System.ComponentModel.DataAnnotations;
using Domain.Posts;
using Domain.Shared;

namespace Domain.Blog;

public class Blog(DateTime? createdAt = null) : Entity(createdAt)
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Vai se foder filho da puta")]
  [Url(ErrorMessage = "O campo precisa ser uma URL")]
  public required string Url { get; init; }
  [Required]
  [EmailAddress]
  public required string Email { get; init; }
  public List<Post> Posts { get; } = [];
}