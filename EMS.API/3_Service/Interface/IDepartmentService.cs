using EMS.API.Model;

namespace EMS.API.Service;


public interface IDepartmentService
{

Department CreateDepartment(Department newDepartment);
IEnumerable<Department> FindAllDepartments();
Department? GetDepartmentById(int id);
IEnumerable<Department> GetDepartmentByName(string name);
void DeleteDepartmentById(int id);





}