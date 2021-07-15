using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashpazbashi.BackofficeUI.Web.Features.Tags.Models
{
    public interface ITagPageViewModel
    {
        Task InitializeViewModel();
        List<Tag> Tags { get; set; }
        TagListRequest TagListRequest { get; set; }
        Tag TagForSave { get; set; }
        Task SaveTag();
    }
}
