using System.ComponentModel.DataAnnotations;

namespace StudentRegistrationWebApp.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
    }
}