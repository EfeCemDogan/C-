using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        void ICategoryRepository.Create(Category entity)
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}