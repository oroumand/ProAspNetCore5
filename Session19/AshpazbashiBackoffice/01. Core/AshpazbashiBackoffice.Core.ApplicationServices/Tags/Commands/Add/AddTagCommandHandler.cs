using System;
using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagCommandHandler : RequestHandler<AddTagCommand, Guid>
    {
        private readonly ITagRepository tagRepository;

        public AddTagCommandHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }
        protected override Guid Handle(AddTagCommand request)
        {
            var tag = new Tag
            {
                Id = Guid.NewGuid(),
                Title = request.Title
            };

            tagRepository.Insert(tag);

            return tag.Id;
        }
    }
}
