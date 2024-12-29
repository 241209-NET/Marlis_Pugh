using EMS.API.Repository;
using EMS.API.Model;



namespace EMS.API.Service;

public class EmployeeService : IEmployeeService
{

    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }




    public Employee CreateEmployee(Employee newEmp)
    {
        return _employeeRepository.CreateEmployee(newEmp);
    }

    public IEnumerable<Employee> FindAllEmps()
    {
        var empList = _employeeRepository.FindAllEmps();
        return empList;
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }

    public Employee? GetEmployeeById(int id)
    {
        if(id < 1) return null;
        return _employeeRepository.GetEmployeeById(id);
    }

    public Employee? DeleteEmployeeById(int id)
    {
          var p = GetEmployeeById(id);
        if(p is not null) _employeeRepository.DeleteEmployeeById(id);
        return p;
    }

    public Employee? UpdateEmployeeById(int id, string Fname)
    {

        Employee? emp = GetEmployeeById(id);
        if(emp is not null) _employeeRepository.UpdateEmployeeById(id, Fname);
        return emp;
       
    }
}