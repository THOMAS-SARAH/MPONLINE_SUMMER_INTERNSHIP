using System.ComponentModel.DataAnnotations;

namespace ExpenseSharingApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}
