using Core.Interfaces;
using Domain.Blog.Dtos;

namespace Domain.Blog;

public interface IBlogRepository<Context> : IRepository<Context> 
  where Context : IDatabaseContext
{
  public Task<Blog> Create(CreateBlogDTO content);
  public Task<Blog?> FindById(string id);
  public abstract Task<Blog?> UpdateById(string id, UpdateBlogDTO data);
  public abstract Task<bool> DeleteById(string id);
}
