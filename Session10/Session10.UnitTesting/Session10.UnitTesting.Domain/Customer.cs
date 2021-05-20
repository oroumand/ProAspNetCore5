using System.Collections.Generic;

namespace Session10.UnitTesting.Domain
{
    public class Customer
    {
        private Dictionary<Product, int> _basket = new Dictionary<Product, int>();
        public bool Purchase(IStore store, Product product, int count)
        {
            if (store.HadEnough(product, count))
            {
                //store.RemoveProduct(product, count);
                AddToBasket(product, count);
                return true;
            }
            return false;
        }

        private void AddToBasket(Product product, int count)
        {
            _basket[product] = count;
        }

        public int Inventory(Product product)
        {
            if (_basket.ContainsKey(product))
                return _basket[product];
            return 0;
        }
    }
}
