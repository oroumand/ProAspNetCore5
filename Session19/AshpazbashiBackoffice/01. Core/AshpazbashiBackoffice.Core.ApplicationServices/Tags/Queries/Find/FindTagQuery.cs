using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.Find
{
    public class FindTagQuery : IRequest<Tag>
    {
        public Guid TagId { get; set; }
    }
}
