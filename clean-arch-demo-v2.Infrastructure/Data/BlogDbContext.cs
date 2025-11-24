using clean_arch_demo_v2.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace clean_arch_demo_v2.Infrastructure.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
