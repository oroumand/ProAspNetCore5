using Ashpazbashi.BackofficeUI.Web.Features.Common;

namespace Ashpazbashi.BackofficeUI.Web.Features.Tags.Models
{
    public class AddTagRequest : BaseRequest
    {

        public AddTagRequest(string requestUrl) : base(requestUrl)
        {
        }
        public string Title { get; set; }
    }
}
