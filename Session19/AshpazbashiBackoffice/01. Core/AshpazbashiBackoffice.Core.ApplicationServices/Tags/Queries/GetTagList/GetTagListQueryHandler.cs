using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.GetTagList
{
    public class GetTagListQueryHandler : RequestHandler<GetTagListQuery, List<Tag>>
    {
        private readonly ITagRepository tagRepository;

        public GetTagListQueryHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        protected override List<Tag> Handle(GetTagListQuery request)
        {
            return tagRepository.GetAll().ToList();
        }
    }
}
