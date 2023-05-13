using Entities.Entities;
using Domain.Interfaces.Generics;

namespace Domain.Interfaces.IExpenditure
{
    public interface IExpenditure : IGeneric<Expenditure> 
    {
        Task<IList<Expenditure>> GetAllExpenditureUserAsync(string emailUser);

        Task<IList<Expenditure>> GetAllExpenditureUserNotPaidBeforeMonthAsync(string emailUser);
    }
}