using Session06.DI.Domain;
using System.Collections.Generic;

namespace Session06.DI.DataAccess
{
    public class FakePersonRepository : IPersonRepository
    {
        private List<Person> _people;

        public FakePersonRepository(int totalCount, string firstName, string lastName)
        {
            _people = new List<Person>(totalCount)
            {
                new Person
                {
                    FirstName = firstName,
                    LastName= lastName
                }
            };
        }
        public FakePersonRepository()
        {
            _people = new List<Person>();
        }
        public void Add(Person person)
        {
            person.Id = _people.Count + 1;
            _people.Add(person);
        }
    }
}
