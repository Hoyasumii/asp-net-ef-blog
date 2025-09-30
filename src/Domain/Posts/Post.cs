using Domain.Shared;

namespace Domain.Posts;


public class Post(DateTime? createdAt) : Entity(createdAt)
{
  public required string Title { get; set; }
  public required string Content { get; set; }
  public required string BlogId { get; set; }
  public required Blog.Blog Blog { get; set; }
}
