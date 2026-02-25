using TodoApp.DTOs;
using TodoApp.Models;

namespace TodoApp.Contract;

public interface IEmployeeService
{
    Employee AddEmployee(Employee employee);
    Employee GetEmployee(int id);
    IEnumerable<GetEmployeeDto> GetAllEmployees();
    bool DeleteEmployee(int id);
    bool UpdateEmployee(Employee employee);
}
