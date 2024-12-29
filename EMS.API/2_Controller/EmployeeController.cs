using Microsoft.AspNetCore.Authorization;
using EMS.API.Model;
using EMS.API.Service;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;


namespace EMS.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    
    private readonly IEmployeeService _employeeService;

    public EmployeeController (IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetAllEmployees() 
    {
        var empList = _employeeService.FindAllEmps();
        IActionResult VerbStatus = Ok(empList);
        
        return VerbStatus;
    }

    [HttpPost]
    public IActionResult CreateEmployee(Employee newEmployee)
    {
        var emp = _employeeService.CreateEmployee(newEmployee);
        var VerbStatus = Ok(emp);

        return VerbStatus;
    }

     [HttpDelete]
    public IActionResult DeleteEmployee(int id)
    {
        var deleteEmp = _employeeService.DeleteEmployeeById(id);

        if(deleteEmp is null) return NotFound();
        var VerbStatus = Ok(deleteEmp);

        return VerbStatus;
    }

     [HttpPut]
    public IActionResult UpdateEmployee(int id, string Fname)
    {
        var updateEmp = _employeeService.UpdateEmployeeById(id, Fname);

        if(updateEmp is null) return NotFound();
        var VerbStatus = Ok(updateEmp);

        return VerbStatus;
    }






}