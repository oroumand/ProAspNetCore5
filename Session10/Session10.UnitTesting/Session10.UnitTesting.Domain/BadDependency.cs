using System;
using System.Collections.Generic;
using System.Text;

namespace Session10.UnitTesting.Domain
{
    public class BadDependency
    {
        public BadDependency()
        {
            System.Threading.Thread.Sleep(4000);
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public bool True() => true;
    }
}
