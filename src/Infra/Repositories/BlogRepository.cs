namespace Infra.Repositories;

using Domain.Blogs;
using Domain.Blogs.Dtos;
using Infra.Interfaces;
using Infra.Repositories.Blogs;

public class BlogRepository : IBlogRepository<IApplicationContext>
{

  public IApplicationContext Context { get; }
  public Func<Blog, Task<Blog>> Create { get; }
  

  public BlogRepository(IApplicationContext context)
  {
    Context = context;
    Create = new CreateBlog<IApplicationContext>(context, this).Method;
  }

  public async Task<Blog?> FindById(string id)
  {
    Blog? targetEntity = await Context.Blogs.FindAsync(id);

    return targetEntity;
  }

  public async Task<Blog?> UpdateById(string id, UpdateBlogDTO data)
  {
    Blog? targetEntity = await Context.Blogs.FindAsync(id);

    if (targetEntity == null) return null;

    targetEntity.Url = data.Url;

    await Context.Save();

    return targetEntity;
  }

  public async Task<bool> DeleteById(string id)
  {
    Blog? targetEntity = await Context.Blogs.FindAsync(id);

    if (targetEntity == null) return false;

    Context.Blogs.Remove(targetEntity);

    await Context.Save();

    return true;
  }
}