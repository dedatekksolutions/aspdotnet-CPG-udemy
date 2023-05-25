using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BloggieDbContext bloggieDbContext;

        public BlogPostRepository(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

         async Task<BlogPost> IBlogPostRepository.AddAsync(BlogPost blogPost)
        {
            await bloggieDbContext.AddAsync(blogPost);
            await bloggieDbContext.SaveChangesAsync();
            return blogPost;
        }

        Task<BlogPost?> IBlogPostRepository.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<BlogPost>> IBlogPostRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<BlogPost?> IBlogPostRepository.GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<BlogPost?> IBlogPostRepository.UpdateAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
