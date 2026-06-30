using System.ComponentModel.DataAnnotations;

namespace ExpenseSharingApp.Models
{
    public class GroupMember
    {
        [Key]
        public int GroupMemberId { get; set; }

        public int GroupId { get; set; }

        public int UserId { get; set; }

        public Group Group { get; set; }

        public User User { get; set; }
    }
}
