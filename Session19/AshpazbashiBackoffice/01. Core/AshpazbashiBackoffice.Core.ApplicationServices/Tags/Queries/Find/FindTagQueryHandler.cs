using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.Find
{
    public class FindTagQueryHandler : RequestHandler<FindTagQuery, Tag>
    {
        private readonly ITagRepository tagRepository;

        public FindTagQueryHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        protected override Tag Handle(FindTagQuery request)
        {
            return tagRepository.Get(request.TagId);
        }
    }
}
