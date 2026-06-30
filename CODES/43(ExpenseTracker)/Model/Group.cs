using System.ComponentModel.DataAnnotations;

namespace ExpenseSharingApp.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        public string GroupName { get; set; }
    }
}
