using System;

namespace Session14.BalzorRouterSample.Features.Posts
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
    }
}
