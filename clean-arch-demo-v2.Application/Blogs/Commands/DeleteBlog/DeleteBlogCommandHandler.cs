using clean_arch_demo_v2.Domain.Repository;
using MediatR;

namespace clean_arch_demo_v2.Application.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
    {
        private readonly IBlogRepository _blogRepository;

        public DeleteBlogCommandHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogRepository.DeleteAsync(request.Id);
        }
    }
}
