using EMS.API.Model;

namespace EMS.API.Repository;


public interface IDepartmentRepository
{

Department CreateDepartment(Department newDepartment);
IEnumerable<Department> FindAllDepartments();
Department? GetDepartmentById(int id);
IEnumerable<Department> GetDepartmentByName(string name);
void DeleteDepartmentById(int id);
Department? UpdateDepartmentById(int id, string name);





}