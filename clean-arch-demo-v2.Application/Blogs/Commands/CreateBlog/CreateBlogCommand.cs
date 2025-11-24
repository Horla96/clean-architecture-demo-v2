using clean_arch_demo_v2.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace clean_arch_demo_v2.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand : IRequest<BlogVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
