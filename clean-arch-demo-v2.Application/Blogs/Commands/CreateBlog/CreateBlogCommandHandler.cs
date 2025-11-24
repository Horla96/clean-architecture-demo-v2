using AutoMapper;
using clean_arch_demo_v2.Application.Blogs.Queries.GetBlogs;
using clean_arch_demo_v2.Domain.Entity;
using clean_arch_demo_v2.Domain.Repository;
using MediatR;

namespace clean_arch_demo_v2.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog() { Name = request.Name, Description = request.Description, Author = request.Author };
            var result = await _blogRepository.CreateAsync(blogEntity);

            return _mapper.Map<BlogVm>(result);
        }
    }
}
