using Microsoft.EntityFrameworkCore;
using EMS.API.Data;
using EMS.API.Model;


namespace EMS.API.Repository;



public class EmployeeRepository : IEmployeeRepository
{

private readonly EmployeeContext _empContext;


public EmployeeRepository(EmployeeContext empContext)
{
    _empContext = empContext;
}

    public Employee CreateEmployee(Employee newEmp)
    {
            _empContext.Employees.Add(newEmp);
            _empContext.SaveChanges();

            return newEmp;    
    }

    public void DeleteEmployeeById(int id)
    {
        Employee? emp = GetEmployeeById(id);
        
            _empContext.Employees.Remove(emp!);
            _empContext.SaveChanges();
        
    }


    public Employee? GetEmployeeById(int id)
    {
        return _empContext.Employees.Find(id);
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }


    IEnumerable<Employee> IEmployeeRepository.FindAllEmps()
    {
        return _empContext.Employees.ToList();
    }

    public Employee? UpdateEmployeeById(int id, string Fname)
    {
        
        Employee? emp = GetEmployeeById(id);
        emp!.Fname = Fname; 
        _empContext.Employees.Update(emp);
        _empContext.SaveChanges();

        return emp;
    }
}