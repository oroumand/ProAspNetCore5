using Session06.DI.Domain;

namespace Session06.DI.DataAccess
{
    public interface IPersonRepository
    {
        void Add(Person person);
    }
}