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
        throw new NotImplementedException();
    }

    public void DeleteRoleById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Role> FindAllRoles()
    {
        var roleList = _roleRepository.FindAllRoles();
        return roleList;
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