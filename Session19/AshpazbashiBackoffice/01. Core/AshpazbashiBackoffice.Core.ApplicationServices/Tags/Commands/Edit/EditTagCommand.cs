using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
