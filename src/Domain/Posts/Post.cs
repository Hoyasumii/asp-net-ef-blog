using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core;
using Domain.Blogs;

namespace Domain.Posts;

[Table("posts_tests")]
public class Post : Entity
{
  [MinLength(4, ErrorMessage = "The Title must be Defined.")]
  public required string Title { get; set; }
  
  [MinLength(4, ErrorMessage = "The Content must be Defined.")]
  public required string Content { get; set; }
  
  [ForeignKey(nameof(Blog))]
  public required Guid BlogId { get; set; }
}