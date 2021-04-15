using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace StateManagement.Cache.Infra
{
    public class DistributedCacheAdapter : ICacheAdapter
    {
        private readonly IDistributedCache _distributed;

        public DistributedCacheAdapter(IDistributedCache distributed)
        {
            _distributed = distributed;
        }
        public TOutput Get<TOutput>(string key)
        {
            var serializedObject = _distributed.GetString(key);
            var result = default(TOutput);
            if(!string.IsNullOrEmpty(serializedObject))
            {
                result = JsonConvert.DeserializeObject<TOutput>(serializedObject);
            }
            return result;
        }

        public void Set<TInput>(string key, TInput input)
        {
            var serializedObject = JsonConvert.SerializeObject(input);
            _distributed.SetString(key, serializedObject);
        }
    }
}
