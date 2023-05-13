using Entities.Entities;
using Domain.Interfaces.Generics;

namespace Domain.Interfaces.IUserFinancialSystem
{
    public interface IUserFinancialSystem : IGeneric<UserFinancialSystem> 
    {
        Task<IList<UserFinancialSystem>> GetAllUserFinancialSystemAsync(int systemId);

        Task RemoverUser(List<UserFinancialSystem> user);

        Task<UserFinancialSystem> GetUserFinancialSystemByEmailAsync(string emailUser);
    }
}