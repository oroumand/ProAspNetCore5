using Session06.DI.DataAccess;

namespace Session06.DI.Infrastructures
{
    public class PersonRepositoryFactory
    {
        private static IPersonRepository _repository;
        public static IPersonRepository GetPersonRepository()
        {
            if(_repository == null)
             _repository = new  FakePersonRepository(10,"Alireza","Oroumand");
            return _repository;
        }
    }
}
