using Entities.Entities;
using Domain.Interfaces.Generics;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem : IGeneric<FinancialSystem> 
    {
        Task<IList<FinancialSystem>> GetAllFinancialSystemUserAsync(string emailUser);
    }
}