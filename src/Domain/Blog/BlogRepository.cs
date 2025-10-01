using Core.Shared;

namespace Domain.Blog;

public class BlogRepository(RepositoryProvider<Blog> provider) : Repository<Blog>
{
  public RepositoryProvider<Blog> Provider { get; } = provider;

  public Task<Blog> Create(Blog content)
  {
    throw new NotImplementedException();
  }

  public Task<bool> DeleteById(string id)
  {
    throw new NotImplementedException();
  }

  public Task<Blog?> FindById(string id)
  {
    throw new NotImplementedException();
  }

  public Task<Blog?> UpdateById(string id)
  {
    throw new NotImplementedException();
  }
}
