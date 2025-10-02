

using Application;
using Domain.Blog;

namespace Infra.Repositories;

public class BlogRepository<ContextType>(ContextType context) : Domain.Blog.BlogRepository<ContextType>(context) where ContextType : ApplicationContext
{
  public override Task<Blog> Create(Blog content)
  {
    throw new NotImplementedException();
  }

  public override Task<bool> DeleteById(string id)
  {
    throw new NotImplementedException();
  }

  public override Task<Blog?> FindById(string id)
  {
    throw new NotImplementedException();
  }

  public override Task<Blog?> UpdateById(string id)
  {
    throw new NotImplementedException();
  }
}