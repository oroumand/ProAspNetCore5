using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace StateManagement.Cache.Infra
{
    public class MomoryCacheAdapter : ICacheAdapter
    {
        private readonly IMemoryCache _memoryCache;

        public MomoryCacheAdapter(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public TOutput Get<TOutput>(string key)
        {
            var cacheValue = _memoryCache.Get(key);
            TOutput output = default(TOutput);
            if (cacheValue != null)
            {
                var stringResult = cacheValue.ToString();
                output = JsonConvert.DeserializeObject<TOutput>(stringResult);
            }

            return output;

        }

        public void Set<TInput>(string key, TInput input)
        {
            var serializedObject = JsonConvert.SerializeObject(input);

            _memoryCache.Set(key, serializedObject);
        }
    }
}
