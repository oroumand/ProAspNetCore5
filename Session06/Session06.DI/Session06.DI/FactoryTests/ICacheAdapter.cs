using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session06.DI.FactoryTests
{
    public interface ICacheAdapter
    {
        void Add<T>(T input);
        void Get<T>(string key);
    }
    public class InMemoryCache : ICacheAdapter
    {
        public void Add<T>(T input)
        {
            throw new NotImplementedException();
        }

        public void Get<T>(string key)
        {
            throw new NotImplementedException();
        }
    }

    public class DistributedCache : ICacheAdapter
    {
        public void Add<T>(T input)
        {
            throw new NotImplementedException();
        }

        public void Get<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
}
