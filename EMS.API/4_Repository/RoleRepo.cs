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
         _empContext.Roles.Add(newRole);
            _empContext.SaveChanges();

            return newRole; 
    }

    public void DeleteRoleById(int id)
    {
        Role? role = GetRoleById(id);
        
            _empContext.Roles.Remove(role!);
            _empContext.SaveChanges();
    }

    public IEnumerable<Role> FindAllRoles()
    {
        return _empContext.Roles.ToList();
    }

    public Role? GetRoleById(int id)
    {
        return _empContext.Roles.Find(id);
    }

    public IEnumerable<Role> GetRoleByName(string name)
    {
        throw new NotImplementedException();
    }

    public Role? UpdateRoleById(int id, string name)
    {
        
        Role? role = GetRoleById(id);
        role!.Name = name; 
        _empContext.Roles.Update(role);
        _empContext.SaveChanges();

        return role;
    }
}