using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Session14.HttpClientSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Session14.HttpClientSamples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PostsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using var httpClient = _httpClientFactory.CreateClient("jsonplaceholder");
            var result = await httpClient.GetAsync("posts");
            var isSuccess = result.IsSuccessStatusCode;
            var stringValue = await result.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Post>>(stringValue);
            return Ok(posts);

        }
    }
}
