namespace Infra.Repositories;

using Core.Interfaces;
using Domain.Blog;
using Domain.Blog.Dtos;
using Domain.Shared;
using Infra.Interfaces;

public class BlogRepository(IApplicationContext context) : IBlogRepository<IApplicationContext>
{

  public IApplicationContext Context { get; } = context;

  public async Task<Blog> Create(CreateBlogDTO content)
  {
    DTOValidator validator = new(content);

    if (!validator.IsValid) { }

    Blog newInstance = new()
    {
      Url = content.Url
    };

    await Context.Blogs.AddAsync(newInstance);

    return newInstance;
  }
}