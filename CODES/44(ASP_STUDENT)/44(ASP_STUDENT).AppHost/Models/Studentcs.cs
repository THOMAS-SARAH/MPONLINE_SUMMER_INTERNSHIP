using System.ComponentModel.DataAnnotations;

namespace ASP_ADO_Student.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
}
