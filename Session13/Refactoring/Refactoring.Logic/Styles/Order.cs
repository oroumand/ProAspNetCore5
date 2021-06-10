using System.Collections.Generic;
using System.Linq;

namespace Refactoring.Logic.Styles
{
    public class Order
    {
        private readonly List<Product> _products = new List<Product>();
        public IReadOnlyList<Product> Products => _products.ToList();
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
