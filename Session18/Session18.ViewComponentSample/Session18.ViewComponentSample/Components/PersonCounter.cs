using Microsoft.AspNetCore.Mvc;
using Session18.ViewComponentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Components
{
    public class PersonCounter:ViewComponent
    {
        private readonly IPersonRepository personRepository;

        public PersonCounter(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public string Invoke()
        {
            var totalCount = personRepository.TotalCount();
            string result = $"تعداد کل برابر است با {totalCount} نفر.";
            return result;
        }
    }
}
