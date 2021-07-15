using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System.Collections.Generic;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.GetTagList
{
    public class GetTagListQuery : IRequest<List<Tag>>
    {
    }
}
