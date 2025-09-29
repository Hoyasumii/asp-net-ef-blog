using Blog.Domain.Posts;
using Blog.Domain.Shared;

namespace Blog.Domain.Blog;

public class Blog(DateTime? createdAt) : Entity(createdAt)
{
  public required string Url { get; set; }
  public List<Post> Posts { get; } = [];
}