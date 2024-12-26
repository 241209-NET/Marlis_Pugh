using Microsoft.AspNetCore.Mvc;


namespace EMS.API.Controller;

[Route("/")]
[ApiController]
public class EmployeeController : ControllerBase
{
    List<Employee> EmpList = [];


    [HttpGet]
    public IActionResult GetAllEmployees() 
    {
        IActionResult VerbStatus = Ok(EmpList);
        
        return VerbStatus;
    }






}