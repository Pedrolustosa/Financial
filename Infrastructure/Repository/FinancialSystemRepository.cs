using Entities.Entities;
using Domain.Interfaces.IFinancialSystem;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class FinancialSystemRepository : GenericRepository<FinancialSystem>, IFinancialSystem
    {
        public Task<IList<FinancialSystem>> GetAllFinancialSystemUserAsync(string emailUser)
        {
            throw new NotImplementedException();
        }
    }
}