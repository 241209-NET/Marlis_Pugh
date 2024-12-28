using EMS.API.Model;




namespace EMS.API.Repository;


public interface IRoleRepository
{

Role CreateRole(Role newRole);
IEnumerable<Role> FindAllRoles();
Role? GetRoleById(int id);
IEnumerable<Role> GetRoleByName(string name);
void DeleteRoleById(int id);





}