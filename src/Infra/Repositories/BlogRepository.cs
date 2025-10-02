namespace Infra.Repositories;

using Domain.Blog;
using Domain.Blog.Dtos;
using Infra.Interfaces;

public class BlogRepository(IApplicationContext context) : IBlogRepository<IApplicationContext>
{

  public IApplicationContext Context { get; } = context;

  public async Task<Blog> Create(CreateBlogDTO content)
  {
    Blog newInstance = new()
    {
      Url = content.Url
    };

    await Context.Blogs.AddAsync(newInstance);

    await Context.Save();

    return newInstance;
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