using Microsoft.EntityFrameworkCore;
using EMS.API.Data;
using EMS.API.Model;


namespace EMS.API.Repository;



public class DepartmentRepository : IDepartmentRepository
{
private readonly EmployeeContext _empContext;

    public DepartmentRepository(EmployeeContext empContext)
    {
        _empContext = empContext;
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
        return _empContext.Departments.ToList();
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