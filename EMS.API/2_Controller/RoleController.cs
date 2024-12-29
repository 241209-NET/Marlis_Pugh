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

     [HttpDelete]
    public IActionResult DeleteRole(int id)
    {
        var deleteRole = _roleService.DeleteRoleById(id);

        if(deleteRole is null) return NotFound();
        var VerbStatus = Ok(deleteRole);

        return VerbStatus;
    }

     [HttpPut]
    public IActionResult UpdateRole(int id, string name)
    {
        var updateRole = _roleService.UpdateRoleById(id, name);

        if(updateRole is null) return NotFound();
        var VerbStatus = Ok(updateRole);

        return VerbStatus;
    }






}