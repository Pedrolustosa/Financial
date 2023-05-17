using Entities.Entities;
using Domain.Interfaces.IServices;
using Domain.Interfaces.IExpenditure;

namespace Domain.Services
{
    /// <summary>
    /// The expenditure service.
    /// </summary>
    public class ExpenditureService : IExpenditureService
    {

        /// <summary>
        /// The interface expenditure.
        /// </summary>
        private readonly IExpenditure _iExpenditure;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenditureService"/> class.
        /// </summary>
        /// <param name="iExpenditure">The i expenditure.</param>
        public ExpenditureService(IExpenditure iExpenditure)
        {
            _iExpenditure = iExpenditure;
        }

        /// <summary>
        /// Add expenditure.
        /// </summary>
        /// <param name="expenditure">The expenditure.</param>
        /// <returns>A Task.</returns>
        public async Task AddExpenditure(Expenditure expenditure)
        {
            var date = DateTime.Now;
            expenditure.RegistrationDate = date;
            expenditure.Year = date.Year;
            expenditure.Month = date.Month;

            var validate = expenditure.ValidatePropiertyString(expenditure.Name, "Name");
            if (validate)
                await _iExpenditure.Add(expenditure);
        }

        /// <summary>
        /// Updates the expenditure.
        /// </summary>
        /// <param name="expenditure">The expenditure.</param>
        /// <returns>A Task.</returns>
        public async Task UpdateExpenditure(Expenditure expenditure)
        {
            var date = DateTime.Now;
            expenditure.DateChange = date;

            if(expenditure.Paid)
                expenditure.PaymentDate = date;

            var validate = expenditure.ValidatePropiertyString(expenditure.Name, "Name");
            if (validate)
                await _iExpenditure.Update(expenditure);
        }
    }
}