using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;

public class Todo
{
    [Key]
    public int Id { get; set; }
}
