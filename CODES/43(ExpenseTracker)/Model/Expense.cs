using System.ComponentModel.DataAnnotations;

namespace ExpenseSharingApp.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        public int GroupId { get; set; }

        public int PaidByUserId { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime ExpenseDate { get; set; }

        public Group Group { get; set; }

        public User PaidByUser { get; set; }
    }
}
