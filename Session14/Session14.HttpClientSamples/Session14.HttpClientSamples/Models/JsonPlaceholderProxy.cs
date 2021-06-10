using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Session14.HttpClientSamples.Models
{
    public interface IJsonPlaceholderProxy
    {
        Task<List<Post>> GetPosts();

        Task<List<Album>> GetAlbums();
    }

    public class JsonPlaceholderProxy : IJsonPlaceholderProxy
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceholderProxy(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }

        public async Task<List<Album>> GetAlbums()
        {
            
            var result = await _httpClient.GetAsync("/albums");
            var isSuccess = result.IsSuccessStatusCode;
            var stringValue = await result.Content.ReadAsStringAsync();
            var albums = JsonConvert.DeserializeObject<List<Album>>(stringValue);
            return albums;
        }

        public async Task<List<Post>> GetPosts()
        {
            var result = await _httpClient.GetAsync("/posts");
            var isSuccess = result.IsSuccessStatusCode;
            var stringValue = await result.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Post>>(stringValue);
            return posts;
        }
    }
}
