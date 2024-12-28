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

    public void DeleteEmployeeById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> FindAllEmps()
    {
        var empList = _employeeRepository.FindAllEmps();
        return empList;
    }

    public Employee? GetEmployeeById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }
}