using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagCommandHandler : RequestHandler<EditTagCommand, Guid>
    {
        private readonly ITagRepository tagRepository;

        public EditTagCommandHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        protected override Guid Handle(EditTagCommand request)
        {

            var tag = new Tag
            {
                Id = request.Id,
                Title = request.Title
            };
            tagRepository.Update(tag);
            return tag.Id;
        }
    }
}
