
using Core.Shared;
using Domain.Blog;

namespace Infra.Repositories;

public class BlogRepository(RepositoryProvider<Blog> provider) : IBlogRepository
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
