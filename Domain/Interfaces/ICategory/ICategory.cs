using Entities.Entities;
using Domain.Interfaces.Generics;

namespace Domain.Interfaces.ICategory
{
    public interface ICategory : IGeneric<Category> 
    {
        Task<IList<Category>> GetAllCategoriesUserAsync(string eemailUser);
    }
}