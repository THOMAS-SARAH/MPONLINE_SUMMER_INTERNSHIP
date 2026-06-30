using System.ComponentModel.DataAnnotations;

namespace ExpenseSharingApp.Models
{
    public class ExpenseShare
    {
        [Key]
        public int ExpenseShareId { get; set; }

        public int ExpenseId { get; set; }

        public int UserId { get; set; }

        public decimal ShareAmount { get; set; }

        public Expense Expense { get; set; }

        public User User { get; set; }
    }
}
