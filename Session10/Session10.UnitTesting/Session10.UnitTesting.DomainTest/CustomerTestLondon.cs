using Session10.UnitTesting.Domain;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Session10.UnitTesting.DomainTest
{
    public class CustomerTestLondon
    {
        [Fact]
        [Trait("Maktab","London")]
        public void Purchase_Done_Correct_Whene_Store_Has_Enough_Inventory()
        {
            var customer = new Customer();
            var product = new Product { Name = "Livan" };
            var store = new StoreForValidPurchase();

            var result = customer.Purchase(store, product, 10);

            Assert.True(result);
        }

        [Fact]
        [Trait("Maktab", "London")]
        public void Purchase_Failed_Whene_Store_Has_Not_Enough_Inventory()
        {
            var customer = new Customer();
            var product = new Product { Name = "Livan" };
            var store = new StoreForFailedPurchase();

            var result = customer.Purchase(store, product, 10);

            Assert.False(result);
        }
    }
}
