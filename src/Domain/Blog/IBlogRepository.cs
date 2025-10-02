using Core.Interfaces;
using Domain.Blog.Dtos;

namespace Domain.Blog;

public interface IBlogRepository<Context> : IRepository<Context> 
  where Context : IDatabaseContext
{
  public Task<Blog> Create(CreateBlogDTO content);
  // public abstract Task<Blog?> FindById(string id);
  // public abstract Task<Blog?> UpdateById<ArgumentType>(string id, ArgumentType data) where ArgumentType : class;
  // public abstract Task<bool> DeleteById(string id);
}
