using Entities.Entities;
using Domain.Interfaces.IExpenditure;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class ExpenditureRepository : GenericRepository<Expenditure>, IExpenditure
    {
        public Task<IList<Expenditure>> GetAllExpenditureUserAsync(string emailUser)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Expenditure>> GetAllExpenditureUserNotPaidBeforeMonthAsync(string emailUser)
        {
            throw new NotImplementedException();
        }
    }
}