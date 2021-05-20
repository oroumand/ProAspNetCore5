using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session10.AspNetUnitTesting.Api.Models
{
    public interface ICustomeService
    {
    }

    public class RealService : ICustomeService
    {
    }

    public class FakeService : ICustomeService
    {
    }
}
