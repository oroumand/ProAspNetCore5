using Microsoft.AspNetCore.Mvc;
using Session18.ViewComponentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Components
{
    public class PersonCounterContent:ViewComponent
    {

        private readonly IPersonRepository personRepository;

        public PersonCounterContent(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public IViewComponentResult Invoke()
        {
            var totalCount = personRepository.TotalCount();
            return Content($"<div class='alert alert-seccondry'>این پیام به صورت محتوایی ایجاد شده است. تعداد نفرات{totalCount} نفر است.</div>");
        }
    }
}
