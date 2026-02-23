using Microsoft.AspNetCore.Mvc;
using TodoApp.Contract;

namespace TodoApp.Controllers;

public class EmployeesController : Controller
{
    private readonly IEmployeeService _employeeService;
    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public IActionResult Index()
    {
        var employees = _employeeService.GetAllEmployees();
        return View(employees);
    }
}
