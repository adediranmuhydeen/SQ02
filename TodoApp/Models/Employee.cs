#nullable disable

using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    //navigating properties
    public int CarId { get; set; }
    public Car Car { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public IQueryable<Attendance> Attendances { get; set; }
}

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IQueryable<Employee> Employees { get; set; }
}

public class Attendance
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public int EmployeeId { get; set; }
    public IQueryable<Employee> Employees { get; set; }
}
