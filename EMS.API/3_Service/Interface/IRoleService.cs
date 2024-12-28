using EMS.API.Model;

namespace EMS.API.Service;


public interface IRoleService
{

Role CreateRole(Role newRole);
IEnumerable<Role> FindAllRoles();
Role? GetRoleById(int id);
IEnumerable<Role> GetRoleByName(string name);
void DeleteRoleById(int id);





}