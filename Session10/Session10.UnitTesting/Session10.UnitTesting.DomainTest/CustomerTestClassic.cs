using Session10.UnitTesting.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Session10.UnitTesting.DomainTest
{
    public class CustomerTestClassic
    {
        [Fact]
        [Trait("Maktab", "Classic")]
        public void Purchase_Done_Correct_Whene_Store_Has_Enough_Inventory()
        {
            //Arrang
            var customer = new Customer();
            var store = new Store();
            var product = new Product { Name = "Livan" };
            store.AddProduct(product, 100);

            //Act
            var result = customer.Purchase(store, product, 10);

            //Assert
            Assert.True(result);
            Assert.Equal(90, store.Inventory(product));
            Assert.Equal(10, customer.Inventory(product));
        }

        [Fact]
        [Trait("Maktab", "Classic")]
        public void Purchase_Failed_Whene_Store_Has_Not_Enough_Inventory()
        {
            //Arrang
            var customer = new Customer();
            var store = new Store();
            var product = new Product { Name = "Livan" };
           
            store.AddProduct(product, 20);
            //Act
            var result = customer.Purchase(store, product, 30);
            //Assert
            Assert.False(result);
            Assert.Equal(20, store.Inventory(product));
            Assert.Equal(0, customer.Inventory(product));

        }
    }
}
