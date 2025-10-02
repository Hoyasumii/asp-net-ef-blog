using Core;
using Domain.Blogs;

namespace Domain.Posts;


public class Post : Entity
{
  public required string Title { get; set; }
  public required string Content { get; set; }
  public required string BlogId { get; set; }
  public required Blog Blog { get; set; }
}