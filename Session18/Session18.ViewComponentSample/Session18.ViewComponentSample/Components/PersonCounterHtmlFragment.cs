using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Session18.ViewComponentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Components
{
    public class PersonCounterHtmlFragment:ViewComponent
    {
        private readonly IPersonRepository personRepository;

        public PersonCounterHtmlFragment(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public IViewComponentResult Invoke()
        {
            var totalCount = personRepository.TotalCount();
            HtmlContentViewComponentResult result = new HtmlContentViewComponentResult(new HtmlString($"<div class='alert alert-seccondry'>این پیام به صورت محتوایی ایجاد شده است. تعداد نفرات{totalCount} نفر است.</div>"));
            return result;
        }
    }
}
