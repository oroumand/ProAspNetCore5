namespace Session10.UnitTesting.Domain
{
    public interface IStore
    {
        void AddProduct(Product product, int count);
        bool HadEnough(Product product, int count);
        int Inventory(Product product);
        void RemoveProduct(Product product, int count);
    }
}