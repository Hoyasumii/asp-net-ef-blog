using Core.Interfaces;
using Domain.Posts;

namespace Infra.Interfaces;

public interface IPostActionMethods<in Args, out Output> : IActionMethods<IPostRepository<IEntityFrameworkCoreAsORMContext>, IEntityFrameworkCoreAsORMContext, Args, Output> { }