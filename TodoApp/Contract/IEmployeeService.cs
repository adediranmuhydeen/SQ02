using TodoApp.Models;

namespace TodoApp.Contract;

public interface IEmployeeService
{
    Employee AddEmployee(Employee employee);
    Employee GetEmployee(int id);
    IEnumerable<Employee> GetAllEmployees();
    bool DeleteEmployee(int id);
    bool UpdateEmployee(Employee employee);
}
