
// using Core.Shared;
// using Domain.Blog;
// using Infra.Providers;

// namespace Infra.Repositories;

// public class BlogRepository
// {
//     public static Domain.Blog.BlogRepository Make()
//     {
//         RepositoryProvider<Blog> provider = new PostgresProvider();
//         return new Domain.Blog.BlogRepository();
//     }
// }