using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Delete
{
    public class DeleteTagCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
