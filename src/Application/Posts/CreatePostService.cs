using Application.Shared.Exceptions;
using Core.Interfaces;
using Core.Validators;
using Domain.Posts;
using Domain.Posts.Dtos;

namespace Application.Posts;

public sealed class CreatePostService(IPostRepository<IDatabaseContext> repository) : IService<IPostRepository<IDatabaseContext>, CreatePostDTO, Post>
{
  private IPostRepository<IDatabaseContext> Repository { get; } = repository;

  public async Task<Post> Run(CreatePostDTO data)
  {
    DTOValidator validator = new(data);

    if (!validator.IsValid)
    {
      throw new InvalidArgumentException("Post");
    }

    var newPost = new Post
    {
      BlogId = data.BlogId,
      Content = data.Content,
      Title = data.Title
    };

    var targetPost = await Repository.Create(newPost);

    return targetPost;
  }
}