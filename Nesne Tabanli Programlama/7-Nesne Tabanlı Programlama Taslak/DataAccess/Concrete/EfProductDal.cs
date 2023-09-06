using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        void IRepository<Product>.Create(Product entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Product[] IProductRepository.GetProductByCategory(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}