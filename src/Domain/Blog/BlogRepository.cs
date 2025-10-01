using Core.Shared;

namespace Domain.Blog;

public abstract class BlogRepository<Context>(Context context) : Repository<Blog, DatabaseContext>(context) where Context : DatabaseContext
{
}
