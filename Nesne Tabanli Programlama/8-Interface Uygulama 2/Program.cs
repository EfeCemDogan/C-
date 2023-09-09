using System;
using System.Globalization;
using System.Reflection;
using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.DataAccess.Concrete;
using ConsoleApp.Entity;

namespace ConsoleApp
{

    class ProductManager : IProductRepository
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product()); 

            // var productRepository = new ProductManager (new EfProductDal());
            var productRepository = new ProductManager (new MySQLProductDal());

            
            productDal.Create(new Product());

        }
    }
}
