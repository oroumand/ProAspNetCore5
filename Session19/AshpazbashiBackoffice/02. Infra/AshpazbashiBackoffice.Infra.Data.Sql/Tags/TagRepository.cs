using AshpazbashiBackoffice.Core.Domain.Tags;
using AshpazbashiBackoffice.Infra.Data.Sql.Common;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Tags
{
    public class TagRepository : EfRepository<Tag>, ITagRepository
    {
        public TagRepository(AshpazbashiDbContext ashpazbashiDbContext) : base(ashpazbashiDbContext)
        {
        }
    }
}
