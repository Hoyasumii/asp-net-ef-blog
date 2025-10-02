namespace Application.Repositories;

using Application;
using Domain.Blog;
using Domain.Blog.Dtos;
using Domain.Shared;

public class BlogRepository(ApplicationContext context) : BlogRepository<ApplicationContext>(context)
{
  public override async Task<Blog> Create(CreateBlogDTO content)
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