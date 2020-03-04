using AH.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AH.API.Database
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext(DbContextOptions<BlogPostContext> options) : base(options) {}
        
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}