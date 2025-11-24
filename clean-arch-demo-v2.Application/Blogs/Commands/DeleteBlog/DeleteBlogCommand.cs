using MediatR;

namespace clean_arch_demo_v2.Application.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
