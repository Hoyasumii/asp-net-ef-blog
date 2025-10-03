using Core.Interfaces;
using Domain.Blogs;

namespace Infra.Interfaces;

public interface IBlogActionMethods<in Args, out Output> : IActionMethods<IBlogRepository<IApplicationContext>, IApplicationContext, Args, Output>
{
}