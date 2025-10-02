using System.ComponentModel.DataAnnotations;
using Domain.Posts;
using Core;

namespace Domain.Blogs;

public class Blog : Entity
{
  [Required(AllowEmptyStrings = false, ErrorMessage = "Vai se foder filho da puta")]
  [Url(ErrorMessage = "O campo precisa ser uma URL")]
  public required string Url { get; set; }
  public List<Post> Posts { get; } = [];
}

// TODO: Se eu estiver de bom humor em algum momento, eu vou implementar os Object Values