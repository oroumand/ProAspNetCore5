using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session14.HttpClientSamples.Models
{
    public class Album
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class Post
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
