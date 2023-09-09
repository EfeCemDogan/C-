using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductByCategory(int id);
        Product[] GetPopularProducts();
    }
}