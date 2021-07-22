using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetFiltersSample.Infrastructures
{
    public interface IExeptionLogger
    {
        Guid Log(Exception exception);
    }

    public class InMemoryExeptionLogger : IExeptionLogger
    {
        private Dictionary<Guid, Exception> db = new Dictionary<Guid, Exception>();

        public Guid Log(Exception exception)
        {
            var id = Guid.NewGuid();

            db[id] = exception;
            return id;
        }
    }
}
