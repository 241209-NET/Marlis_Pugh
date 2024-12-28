using Microsoft.EntityFrameworkCore;
using EMS.API.Data;
using EMS.API.Model;


namespace EMS.API.Repository;



public class RoleRepository : IRoleRepository
{

    private readonly EmployeeContext _empContext;

    public RoleRepository(EmployeeContext empContext)
    {
        _empContext = empContext;
    }

    public Role CreateRole(Role newRole)
    {
        throw new NotImplementedException();
    }

    public void DeleteRoleById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Role> FindAllRoles()
    {
        return _empContext.Roles.ToList();
    }

    public Role? GetRoleById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Role> GetRoleByName(string name)
    {
        throw new NotImplementedException();
    }
}