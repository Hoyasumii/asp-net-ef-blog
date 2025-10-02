using Application.Blogs;
using Infra.Built;
using Infra.Repositories;

namespace Infra.Factories.Blogs;

public class CreateBlogFactory
{
  public static CreateBlogService<BlogRepository> Make()
  {
    ApplicationContext context = new();
    BlogRepository repository = new(context);

    return new(repository);
  }
}