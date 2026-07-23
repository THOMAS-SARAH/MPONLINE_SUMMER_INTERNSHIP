using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegistrationWebApp.Models
{
    public class CourseRegistration
    {
        public int Id { get; set; }

        [Required]
        public int StudentProfileId { get; set; }

        [Required]
        public int CourseId { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("StudentProfileId")]
        public StudentProfile? StudentProfile { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
    }
}