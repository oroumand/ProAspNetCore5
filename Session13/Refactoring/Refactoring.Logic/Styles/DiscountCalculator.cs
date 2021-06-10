using System;
using System.Linq;
using System.Text;

namespace Refactoring.Logic.Styles
{
    public class Product
    {

    }
    class DiscountCalculator
    {
        public decimal CalculateDiscount(params Product[] products)
        {
            decimal discount = products.Length * 0.01m;
            return Math.Min(discount, 0.2m);
        }
    }
}
