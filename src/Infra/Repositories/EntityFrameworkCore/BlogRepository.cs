namespace Infra.Repositories.EntityFrameworkCore;

using Domain.Blogs;
using Domain.Blogs.Dtos;
using Infra.Interfaces;
using Infra.Repositories.Blogs;

public class BlogRepository: IBlogRepository<IEntityFrameworkCoreAsORMContext>
{

  public IEntityFrameworkCoreAsORMContext Context { get; }
  public Func<Blog, Task<Blog>> Create { get; }
  public Func<string, Task<Blog?>> FindById { get; }
  public Func<UpdateBlogDTO, Task<Blog?>> UpdateById { get; }
  public Func<string, Task<bool>> DeleteById { get; }


  public BlogRepository(IEntityFrameworkCoreAsORMContext context)
  {
    Context = context;
    Create = new CreateBlog(context, this).Method;
    FindById = new FindById(context, this).Method;
    UpdateById = new UpdateById(context, this).Method;
    DeleteById = new DeleteById(context, this).Method;
  }
}