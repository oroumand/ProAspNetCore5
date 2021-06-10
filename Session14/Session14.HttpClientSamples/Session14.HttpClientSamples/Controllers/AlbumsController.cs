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
    public class AlbumsController : ControllerBase
    {
        private readonly IJsonPlaceholderProxy _jsonPlaceholderProxy;

        //private readonly IHttpClientFactory _httpClientFactory;

        //public AlbumsController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        public AlbumsController(IJsonPlaceholderProxy jsonPlaceholderProxy)
        {
            _jsonPlaceholderProxy = jsonPlaceholderProxy;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ablums = _jsonPlaceholderProxy.GetAlbums();
            return Ok(ablums);

        }
    }
}
