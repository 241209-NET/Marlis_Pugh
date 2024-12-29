using EMS.API.Model;

namespace EMS.API.Service;


public interface IEmployeeService
{
Employee CreateEmployee(Employee newEmp);
IEnumerable<Employee> FindAllEmps();
Employee? GetEmployeeById(int id);
IEnumerable<Employee> GetEmployeeByName(string name);
Employee? DeleteEmployeeById(int id);

Employee? UpdateEmployeeById(int id, string Fname);



}


