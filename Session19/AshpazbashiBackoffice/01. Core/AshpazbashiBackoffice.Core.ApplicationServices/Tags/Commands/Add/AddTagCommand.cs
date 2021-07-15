using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagCommand:IRequest<Guid>
    {
        public string Title { get; set; }
    }
}
