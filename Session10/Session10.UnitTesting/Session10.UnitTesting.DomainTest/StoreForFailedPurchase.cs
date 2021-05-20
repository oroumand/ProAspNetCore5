using Session10.UnitTesting.Domain;
using System;

namespace Session10.UnitTesting.DomainTest
{
    public class StoreForFailedPurchase : IStore
    {
        public void AddProduct(Product product, int count)
        {
            throw new NotImplementedException();
        }

        public bool HadEnough(Product product, int count)
        {
            return false;
        }

        public int Inventory(Product product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product, int count)
        {

        }
    }
}
