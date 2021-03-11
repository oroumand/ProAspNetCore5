using Session06.DI.DataAccess;
using Session06.DI.Domain;
using Session06.DI.Infrastructures;

namespace Session06.DI.ApplicaitonService
{
    public class CreatePersonService
    {
        private readonly IPersonRepository _fakePersonRepository;

        //public FakePersonRepository FakePersonRepository { get; set; } = PersonRepositoryFactory.GetPersonRepository();

        public CreatePersonService(IPersonRepository fakePersonRepository)
        {
            _fakePersonRepository = fakePersonRepository;
        }
        public void Create(string firstName,string lastName)
        {
            if(InputDataIsValid(firstName,lastName))
            {
                var repository = _fakePersonRepository;
                repository.Add(new Person
                {
                    FirstName = firstName,
                    LastName = lastName
                });
            }
        }

        private bool InputDataIsValid(string firstName, string lastName) => true;
    }
}
