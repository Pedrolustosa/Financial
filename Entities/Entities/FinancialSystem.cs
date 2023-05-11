using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("FinancialSystem")]
    public class FinancialSystem
    {
        public int Month { get; set; }
        public int Year { get; set; }   
        public int ClosingDay { get; set; }
        public bool GenerateCopyDispense { get; set; }
        public int MonthCopy { get; set; }
        public int YearCopy { get; set; }
    }
}