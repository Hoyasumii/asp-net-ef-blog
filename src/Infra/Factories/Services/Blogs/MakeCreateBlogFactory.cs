using System.Threading.Tasks;
using Application.Blogs;
using Domain.Blogs;
using Infra.Built;
using Infra.Factories.Repositories;
using Infra.Interfaces;
using Infra.Repositories;

namespace Infra.Factories.Services.Blogs;

public class MakeCreateBlogFactory
{
  public static CreateBlogService<IBlogRepository<IApplicationContext>> Run()
  {
    IBlogRepository<IApplicationContext> repository = MakeBlogRepository.Run();

    CreateBlogService<IBlogRepository<IApplicationContext>> service = new(repository);

    return service;
  }
}