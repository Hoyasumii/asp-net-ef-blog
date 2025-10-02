using Core.Shared;
using Domain.Blog.Dtos;

namespace Domain.Blog;

public abstract class BlogRepository<Context>(Context context) : Repository<Blog, Context>(context) where Context : DatabaseContext
{
  public abstract Task<Blog> Create(CreateBlogDTO content);
  // public abstract Task<Blog?> FindById(string id);
  // public abstract Task<Blog?> UpdateById<ArgumentType>(string id, ArgumentType data) where ArgumentType : class;
  // public abstract Task<bool> DeleteById(string id);
}
