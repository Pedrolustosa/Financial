using Entities.Entities;
using Domain.Interfaces.ICategory;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategory
    {
        public Task<IList<Category>> GetAllCategoriesUserAsync(string eemailUser)
        {
            throw new NotImplementedException();
        }
    }
}