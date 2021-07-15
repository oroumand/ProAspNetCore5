using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Ashpazbashi.BackofficeUI.Web.Features.Tags.Models
{
    public class TagPageViewModel : ITagPageViewModel
    {
        private readonly HttpClient client;

        public TagPageViewModel(HttpClient client)
        {

            this.client = client;

        }
        public List<Tag> Tags { get; set; }
        public TagListRequest TagListRequest { get; set; } = new TagListRequest("/api/tags/search");
        public Tag TagForSave { get; set; } = new Tag();

        public async Task InitializeViewModel()
        {
            Tags = await client.GetFromJsonAsync<List<Tag>>(TagListRequest.RequestUrl);
        }

        public async Task SaveTag()
        {
            if (TagForSave.Id != Guid.Empty)
            {
                var addTagRequest = new AddTagRequest("/api/tags");

                await client.PutAsJsonAsync<Tag>(addTagRequest.RequestUrl, TagForSave);

            }
            else
            {
                var addTagRequest = new AddTagRequest("/api/tags");

                await client.PostAsJsonAsync<Tag>(addTagRequest.RequestUrl, TagForSave);
                Tags = await client.GetFromJsonAsync<List<Tag>>(TagListRequest.RequestUrl);
            }

            TagForSave = new Tag();
        }
    }
}
