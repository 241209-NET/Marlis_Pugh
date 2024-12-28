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
        throw new NotImplementedException();
    }

    public void DeleteDepartmentById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Department> FindAllDepartments()
    {
        var departmentList = _departmentRepository.FindAllDepartments();
        return departmentList;
    }

    public Department? GetDepartmentById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Department> GetDepartmentByName(string name)
    {
        throw new NotImplementedException();
    }
}