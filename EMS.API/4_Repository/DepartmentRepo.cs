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
         _empContext.Departments.Add(newDepartment);
            _empContext.SaveChanges();

            return newDepartment; 
    }

    public void DeleteDepartmentById(int id)
    {
        Department? dep = GetDepartmentById(id);
        
            _empContext.Departments.Remove(dep!);
            _empContext.SaveChanges();
    }

    public IEnumerable<Department> FindAllDepartments()
    {
        return _empContext.Departments.ToList();
    }

    public Department? GetDepartmentById(int id)
    {
        return _empContext.Departments.Find(id);
    }

    public IEnumerable<Department> GetDepartmentByName(string name)
    {
        throw new NotImplementedException();
    }

    public Department? UpdateDepartmentById(int id, string name)
    {
        
        Department? dep = GetDepartmentById(id);
        dep!.Name = name; 
        _empContext.Departments.Update(dep);
        _empContext.SaveChanges();

        return dep;
    }
}