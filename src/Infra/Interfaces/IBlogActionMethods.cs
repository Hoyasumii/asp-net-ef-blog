using Core.Interfaces;
using Domain.Blogs;

namespace Infra.Interfaces;

public interface IBlogActionMethods<in Args, out Output> : IActionMethods<IBlogRepository<IEntityFrameworkCoreAsORMContext
>, IEntityFrameworkCoreAsORMContext, Args, Output>
{
}