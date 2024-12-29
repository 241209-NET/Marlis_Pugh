using EMS.API.Model;




namespace EMS.API.Repository;


public interface IEmployeeRepository
{

Employee CreateEmployee(Employee newEmp);
IEnumerable<Employee> FindAllEmps();
Employee? GetEmployeeById(int id);
IEnumerable<Employee> GetEmployeeByName(string name);
void DeleteEmployeeById(int id);

Employee? UpdateEmployeeById(int id, string Fname);





}