using Entities.Entities;
using Infrastructure.Repository.Generics;
using Domain.Interfaces.IUserFinancialSystem;

namespace Infrastructure.Repository
{
    public class UserFinancialSystemRepository : GenericRepository<UserFinancialSystem>, IUserFinancialSystem
    {
        public Task<IList<UserFinancialSystem>> GetAllUserFinancialSystemAsync(int systemId)
        {
            throw new NotImplementedException();
        }

        public Task<UserFinancialSystem> GetUserFinancialSystemByEmailAsync(string emailUser)
        {
            throw new NotImplementedException();
        }

        public Task RemoverUser(List<UserFinancialSystem> user)
        {
            throw new NotImplementedException();
        }
    }
}