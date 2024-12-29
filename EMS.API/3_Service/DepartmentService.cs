using EMS.API.Repository;
using EMS.API.Model;

namespace EMS.API.Service;

public class DepartmentService : IDepartmentService
{

    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public Department CreateDepartment(Department newDepartment)
    {
        return _departmentRepository.CreateDepartment(newDepartment);
    }

    public Department? DeleteDepartmentById(int id)
    {
         var p = GetDepartmentById(id);
        if(p is not null) _departmentRepository.DeleteDepartmentById(id);
        return p;
    }

    public IEnumerable<Department> FindAllDepartments()
    {
        var departmentList = _departmentRepository.FindAllDepartments();
        return departmentList;
    }

    public Department? GetDepartmentById(int id)
    {
        if(id < 1) return null;
        return _departmentRepository.GetDepartmentById(id);
    }

    public IEnumerable<Department> GetDepartmentByName(string name)
    {
        throw new NotImplementedException();
    }

    public Department? UpdateDepartmentById(int id, string name)
    {

        Department? dep = GetDepartmentById(id);
        if(dep is not null) _departmentRepository.UpdateDepartmentById(id, name);
        return dep;
       
    }
}