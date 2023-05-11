using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("UserFinancialSystem")]
    public class UserFinancialSystem
    {
        public int Id { get; set; }
        public string? UserEmail { get; set; }
        public bool Administrator { get; set; }
        public bool AnualSystem { get; set; }

        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int SystemId { get; set; }
        public virtual FinancialSystem? FinancialSystem { get; set; }
    }
}