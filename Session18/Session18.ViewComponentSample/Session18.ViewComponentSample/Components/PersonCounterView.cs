using Microsoft.AspNetCore.Mvc;
using Session18.ViewComponentSample.Models;

namespace Session18.ViewComponentSample.Components
{
    public class PersonCounterView:ViewComponent
    {
        private readonly IPersonRepository personRepository;

        public PersonCounterView(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public IViewComponentResult Invoke(string viewName)
        {
            var totalCount = personRepository.TotalCount();

            if (!string.IsNullOrEmpty(viewName))
                return View(viewName, totalCount);
            return View(totalCount);
        }
    }
}
