// namespace Application.Repositories;

// using Application;
// using Domain.Blog;

// public class BlogRepository(ApplicationContext context) : BlogRepository<ApplicationContext>(context)
// {
//   public override async Task<Blog> Create(Blog content)
//   {
//     return await Context.Blogs.AddAsync(content);
//   }

//   public override Task<bool> DeleteById(string id)
//   {
//     throw new NotImplementedException();
//   }

//   public override Task<Blog?> FindById(string id)
//   {
//     throw new NotImplementedException();
//   }

//   public override Task<Blog?> UpdateById(string id)
//   {
//     throw new NotImplementedException();
//   }
// }