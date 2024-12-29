using EMS.API.Repository;
using EMS.API.Model;

namespace EMS.API.Service;

public class RoleService : IRoleService
{

    private readonly IRoleRepository _roleRepository;

    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public Role CreateRole(Role newRole)
    {
        return _roleRepository.CreateRole(newRole);
    }

    public Role? DeleteRoleById(int id)
    {
         var p = GetRoleById(id);
        if(p is not null) _roleRepository.DeleteRoleById(id);
        return p;
    }

    public IEnumerable<Role> FindAllRoles()
    {
        var roleList = _roleRepository.FindAllRoles();
        return roleList;
    }

    public Role? GetRoleById(int id)
    {
        if(id < 1) return null;
        return _roleRepository.GetRoleById(id);
    }

    public IEnumerable<Role> GetRoleByName(string name)
    {
        throw new NotImplementedException();
    }

    public Role? UpdateRoleById(int id, string name)
    {

        Role? role = GetRoleById(id);
        if(role is not null) _roleRepository.UpdateRoleById(id, name);
        return role;
       
    }
}