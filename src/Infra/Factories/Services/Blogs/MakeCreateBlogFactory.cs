using System.Threading.Tasks;
using Application.Blogs;
using Domain.Blogs;
using Infra.Built;
using Infra.Repositories;

namespace Infra.Factories.Services.Blogs;

public class CreateBlogFactory
{
  public static async Task<CreateBlogService<BlogRepository>> Make()
  {
    ApplicationContext context = new();
    BlogRepository repository = new(context);

    CreateBlogService<BlogRepository> service = new(repository);

    Blog blog = new()
    {
      Url = "https://google.com"
    };

    await repository.Create(blog);

    return new(repository);
  }
}