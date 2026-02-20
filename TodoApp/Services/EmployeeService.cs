using Microsoft.EntityFrameworkCore;
using TodoApp.Contract;
using TodoApp.Data;
using TodoApp.DTOs;
using TodoApp.Models;

namespace TodoApp.Services;

public class EmployeeService : IEmployeeService
{
    private AppDbContext _context;

    public EmployeeService(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public Employee AddEmployee(Employee employee)
    {
        var emp = _context.Employees.Add(employee);
        if(emp != null)
        {
            _context.SaveChanges();
            return emp.Entity;
        }
        return null;
    }

    public bool DeleteEmployee(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<GetEmployeeDto> GetAllEmployees()
    {
        var employees = _context.Employees.ToList();
        return employees;
    }

    public Employee GetEmployee(int id)
    {
        var employee = _context.Employees.Where(x => x.Id == id)
            .Include(x => x.Car)
            .Include(x => x.Department).FirstOrDefault();
        return employee;
    }

    public GetEmployeeDto GetEmploye(int id)
    {
        var employee = _context.Employees.Select(x =>
        new GetEmployeeDto
        {
            FirstName = x.FirstName,
            IsActive = x.IsActive,
            Car = new GetCarDto
            {
                Name = x.Car.Name
            },
            Department = new GetDepartmentDto
            {
                Name = x.Department.Name
            }
        }).FirstOrDefault();
        return employee;
    }

    public bool UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}
