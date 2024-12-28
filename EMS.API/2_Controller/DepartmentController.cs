using Microsoft.AspNetCore.Authorization;
using EMS.API.Model;
using EMS.API.Service;
using Microsoft.AspNetCore.Mvc;


namespace EMS.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    
    private readonly IDepartmentService _departmentService;

    public DepartmentController (IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet]
    public IActionResult GetAllDepartments() 
    {
        var depList = _departmentService.FindAllDepartments();
        IActionResult VerbStatus = Ok(depList);
        
        return VerbStatus;
    }

    [HttpPost]
    public IActionResult CreateDepartment(Department newDepartment)
    {
        var dep = _departmentService.CreateDepartment(newDepartment);
        var VerbStatus = Ok(dep);
        return VerbStatus;
    }






}