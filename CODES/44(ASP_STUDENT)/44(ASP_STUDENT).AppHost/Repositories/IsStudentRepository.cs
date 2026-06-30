using ASP_ADO_Student.Models;

namespace ASP_ADO_Student.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();

        void AddStudent(Student student);
    }
}
