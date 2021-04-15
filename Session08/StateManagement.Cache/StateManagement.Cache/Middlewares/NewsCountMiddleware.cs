using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using StateManagement.Cache.Infra;
using System.Threading.Tasks;

namespace StateManagement.Cache.Middlewares
{
    public class NewsCountMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly NewsRepository _newsRepository;
        private readonly ICacheAdapter _cacheAdapter;

        //private readonly IDistributedCache _distributedCache;
        //private readonly IMemoryCache _memoryCache;

        //public NewsCountMiddleware(RequestDelegate next, NewsRepository newsRepository,IMemoryCache memoryCache)
        //{
        //    _next = next;
        //    _newsRepository = newsRepository;
        //    _memoryCache = memoryCache;
        //}


        //public NewsCountMiddleware(RequestDelegate next, NewsRepository newsRepository, IDistributedCache distributedCache)
        //{
        //    _next = next;
        //    _newsRepository = newsRepository;
        //    _distributedCache = distributedCache;
        //}

        public NewsCountMiddleware(RequestDelegate next, NewsRepository newsRepository, ICacheAdapter cacheAdapter)
        {
            _next = next;
            _newsRepository = newsRepository;
            _cacheAdapter = cacheAdapter;
        }
        public async Task Invoke(HttpContext context)
        {

            //var newsCount = _memoryCache.Get("NewsCount");
            //if (newsCount == null)
            //{
            //    newsCount = _newsRepository.GetNewCount();
            //    _memoryCache.Set("NewsCount", newsCount);
            //}
            var newsCount = _cacheAdapter.Get<string>("NewsCount");
            if (string.IsNullOrEmpty(newsCount))
            {
                newsCount = _newsRepository.GetNewCount().ToString();
                _cacheAdapter.Set("NewsCount", newsCount);
            }

            await context.Response.WriteAsync($"News Count is {newsCount} \n");
            await _next(context);
        }
    }
}
