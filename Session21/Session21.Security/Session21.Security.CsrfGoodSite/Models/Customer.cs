using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session21.Security.CsrfGoodSite.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Emtiaz { get; set; }
    }
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        void SetEmtiaz(int customerId, int newEmtiaz);
    }

    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer{Id =1, Name = "Alrieza Oroumand",Emtiaz= 100 },
            new Customer{Id =2, Name = "Momammad Abbasi",Emtiaz= 80 },
            new Customer{Id =3, Name = "Farid Taheri",Emtiaz= 90 },
            new Customer{Id =4, Name = "Omid Ghorbabi",Emtiaz= 90 },
            new Customer{Id =5, Name = "Sajad Abbasi",Emtiaz= 70 },
            new Customer{Id =6, Name = "Momammadreza Abbaspour",Emtiaz= 80 },
            new Customer{Id =7, Name = "Hamid Saberi",Emtiaz= 60 }
        };
        public InMemoryCustomerRepository()
        {

        }
        public Customer GetCustomer(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }

        public void SetEmtiaz(int customerId, int newEmtiaz)
        {
            customers.FirstOrDefault(c => c.Id == customerId).Emtiaz = newEmtiaz;
        }
    }
}
