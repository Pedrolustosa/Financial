using Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Dispense")]
    public class Dispense : Base
    {
        public decimal Value { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public EnumTypeDipense TypeDipense { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime DateChange { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public bool Paid { get; set; }

        public bool DelayedExpense { get; set; }


        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}