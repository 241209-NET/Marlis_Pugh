using Microsoft.AspNetCore.Authorization;
using EMS.API.Model;
using EMS.API.Service;
using Microsoft.AspNetCore.Mvc;


namespace EMS.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{ 
    
    private readonly IRoleService _roleService;

    public RoleController (IRoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet]
    public IActionResult GetAllRoles() 
    {
        var roleList = _roleService.FindAllRoles();
        IActionResult VerbStatus = Ok(roleList);
        
        return VerbStatus;
    }

    [HttpPost]
    public IActionResult CreateRole(Role newRole)
    {
        var role = _roleService.CreateRole(newRole);
        var VerbStatus = Ok(role);
        return VerbStatus;
    }






}