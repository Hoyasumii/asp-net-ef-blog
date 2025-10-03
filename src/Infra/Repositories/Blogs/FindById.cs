using Core.Dtos;
using Core.Interfaces;
using Domain.Blogs;
using Infra.Interfaces;

namespace Infra.Repositories.Blogs;

public class FindById(IApplicationContext context, IBlogRepository<IApplicationContext> repository) : IBlogActionMethods<GuidDTO, Task<Blog?>>
{
  
}