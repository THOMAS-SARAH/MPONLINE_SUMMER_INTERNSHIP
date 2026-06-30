using ASP_ADO.Models;

namespace ASP_ADO.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
    }
}
