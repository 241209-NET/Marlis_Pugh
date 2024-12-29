

namespace EMS.API.Model;

public class Employee 
{

    public int Id { get; set; }
    public string? Fname { get; set; }
    public string? Lname { get; set; }
    public string? Email { get; set; }
    public AccountHolder? Account { get; set; } 
    public Department? Department { get; set; } 
    public Role? Role { get; set; } 
 





}