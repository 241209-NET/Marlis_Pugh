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
        throw new NotImplementedException();
    }


    public Employee? GetEmployeeById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }


    IEnumerable<Employee> IEmployeeRepository.FindAllEmps()
    {
        return _empContext.Employees.ToList();
    }
}