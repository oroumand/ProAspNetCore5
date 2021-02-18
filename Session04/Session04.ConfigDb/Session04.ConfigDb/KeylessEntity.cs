using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.ConfigDb
{
    //[Keyless]
    public class KeylessEntity
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
    }
    public class KeylessView
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
    }
}
