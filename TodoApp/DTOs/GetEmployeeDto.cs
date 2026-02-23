using System.ComponentModel.DataAnnotations;
using TodoApp.Models;

namespace TodoApp.DTOs;

public class GetEmployeeDto
{
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    public bool IsActive { get; set; }

}

public class GetAttendanceDto
{
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public int EmployeeId { get; set; }
    public IQueryable<GetEmployeeDto> Employees { get; set; }
}

public class GetCarDto
{
    public string Name { get; set; }
}

public class GetDepartmentDto
{
    public string Name { get; set; }
    public IQueryable<GetEmployeeDto> Employees { get; set; }
}
