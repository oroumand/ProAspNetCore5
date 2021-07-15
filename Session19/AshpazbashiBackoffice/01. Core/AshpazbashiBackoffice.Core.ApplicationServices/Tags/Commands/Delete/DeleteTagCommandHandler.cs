using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Delete
{
    public class DeleteTagCommandHandler : RequestHandler<DeleteTagCommand, Guid>
    {
        private readonly ITagRepository tagRepository;

        public DeleteTagCommandHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        protected override Guid Handle(DeleteTagCommand request)
        {

            var tag = new Tag
            {
                Id = request.Id,
            };
            tagRepository.Remove(tag);
            return tag.Id;
        }
    }
}
