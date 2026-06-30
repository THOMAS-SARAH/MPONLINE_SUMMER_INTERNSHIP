using ASP_ADO_Student.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ASP_ADO_Student.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Student";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();

                    s.Id = Convert.ToInt32(reader["Id"]);
                    s.Name = reader["Name"].ToString();
                    s.Department = reader["Department"].ToString();
                    s.Age = Convert.ToInt32(reader["Age"]);

                    students.Add(s);
                }

                con.Close();
            }

            return students;
        }

        public void AddStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Student(Name,Department,Age)
                                 VALUES(@Name,@Department,@Age)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Department", student.Department);
                cmd.Parameters.AddWithValue("@Age", student.Age);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
