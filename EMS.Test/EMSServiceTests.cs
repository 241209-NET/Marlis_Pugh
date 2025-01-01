using System.Collections.Generic;
using EMS.API.Model;
using EMS.API.Repository;
using EMS.API.Service;
using Moq;

namespace EMS.Test;

public class UnitTest1
{
    [Fact]
    public void GetAllEmployees()
    {
        //Arrange
        Mock<IEmployeeRepository> mockRepo = new();
        EmployeeService testService = new(mockRepo.Object);

        List<Employee> testList = [
            new Employee{Id = 1, Fname = "Goose", Lname = "Ribbon"},
            new Employee{Id = 2, Fname = "Go", Lname = "R"},
            new Employee{Id = 3, Fname = "Goo", Lname = "Ribb"}
        ];

        mockRepo.Setup(worker => worker.FindAllEmps()).Returns(testList);

        //Act
        List<Employee> result = testService.FindAllEmps().ToList();

        //Assert
        Assert.Contains(result, action => action.Id == 1);

    }

    [Fact]
    public void CreateNewEmployee()
    {
        //Arrange
        Mock<IEmployeeRepository> mockRepo = new();
        EmployeeService testService = new(mockRepo.Object);

        List<Employee> testList = [
            new Employee{Id = 1, Fname = "Goose", Lname = "Ribbon"},
            new Employee{Id = 2, Fname = "Go", Lname = "R"},
            new Employee{Id = 3, Fname = "Goo", Lname = "Ribb"}
        ];

        Employee workerEmp = new Employee{Id = 10, Fname = "Test", Lname = "Case"};

        mockRepo.Setup(worker => worker.CreateEmployee(workerEmp))
        .Callback((Employee e) => testList.Add(e))
        .Returns(workerEmp);

        //Act
        Employee update = testService.CreateEmployee(workerEmp);

        //Assert
        Assert.Contains(workerEmp, testList);

    }

    [Fact]
    public void GetAllRoles()
    {
        //Arrange
        Mock<IRoleRepository> mockRepo = new();
        RoleService testService = new(mockRepo.Object);

        List<Role> testList = [
            new Role{Id = 1, Name = "User"},
            new Role{Id = 2, Name = "Admin"},
            new Role{Id = 3, Name = "Employee"}
        ];

        mockRepo.Setup(worker => worker.FindAllRoles()).Returns(testList);

        //Act
        List<Role> result = testService.FindAllRoles().ToList();

        //Assert
        Assert.Contains(result, action => action.Id == 2);

    }

    [Fact]
    public void CreateNewRole()
    {
        //Arrange
        Mock<IRoleRepository> mockRepo = new();
        RoleService testService = new(mockRepo.Object);

        List<Role> testList = [
            new Role{Id = 1, Name = "User"},
            new Role{Id = 2, Name = "Admin"},
            new Role{Id = 3, Name = "Employee"}
        ];

        Role workerRole = new Role{Id = 10, Name = "Test"};

        mockRepo.Setup(worker => worker.CreateRole(workerRole))
        .Callback((Role r) => testList.Add(r))
        .Returns(workerRole);

        //Act
        Role update = testService.CreateRole(workerRole);

        //Assert
        Assert.Contains(workerRole, testList);

    }

    [Fact]
    public void GetAllDepartments()
    {
        //Arrange
        Mock<IDepartmentRepository> mockRepo = new();
        DepartmentService testService = new(mockRepo.Object);

        List<Department> testList = [
            new Department{Id = 1, Name = "IT Support"},
            new Department{Id = 2, Name = "Finance"},
            new Department{Id = 3, Name = "Human Resources"}
        ];

        mockRepo.Setup(worker => worker.FindAllDepartments()).Returns(testList);

        //Act
        List<Department> result = testService.FindAllDepartments().ToList();

        //Assert
        Assert.Contains(result, action => action.Id == 3);

    }

    [Fact]
    public void CreateNewDepartment()
    {
        //Arrange
        Mock<IDepartmentRepository> mockRepo = new();
        DepartmentService testService = new(mockRepo.Object);

       List<Department> testList = [
            new Department{Id = 1, Name = "IT Support"},
            new Department{Id = 2, Name = "Finance"},
            new Department{Id = 3, Name = "Human Resources"}
        ];

        Department workerDep = new Department{Id = 10, Name = "Test"};

        mockRepo.Setup(worker => worker.CreateDepartment(workerDep))
        .Callback((Department d) => testList.Add(d))
        .Returns(workerDep);

        //Act
        Department update = testService.CreateDepartment(workerDep);

        //Assert
        Assert.Contains(workerDep, testList);

    }

    [Fact]
    public void GetAllProducts()
    {
        //Arrange
        Mock<IProductsRepository> mockRepo = new();
        ProductsService testService = new(mockRepo.Object);

        List<Products> testList = [
            new Products{Id = 1, Name = "Shirt", Price = 15},
            new Products{Id = 2, Name = "Coffee Cup", Price = 25},
            new Products{Id = 3, Name = "Bumper Sticker", Price = 5}
        ];

        mockRepo.Setup(worker => worker.FindAllProducts()).Returns(testList);

        //Act
        List<Products> result = testService.FindAllProducts().ToList();

        //Assert
        Assert.Contains(result, action => action.Id == 2);

    }

    [Fact]
    public void CreateNewProduct()
    {
        //Arrange
        Mock<IProductsRepository> mockRepo = new();
        ProductsService testService = new(mockRepo.Object);

        List<Products> testList = [
            new Products{Id = 1, Name = "Shirt", Price = 15},
            new Products{Id = 2, Name = "Coffee Cup", Price = 25},
            new Products{Id = 3, Name = "Bumper Sticker", Price = 5}
        ];

        Products workerPro = new Products{Id = 10, Name = "Test", Price = 33};

        mockRepo.Setup(worker => worker.CreateProduct(workerPro))
        .Callback((Products p) => testList.Add(p))
        .Returns(workerPro);

        //Act
        Products update = testService.CreateProduct(workerPro);

        //Assert
        Assert.Contains(workerPro, testList);

    }

    [Fact]
    public void GetAllAccounts()
    {
        //Arrange
        Mock<IAccountHolderRepository> mockRepo = new();
        AccountHolderService testService = new(mockRepo.Object);

        List<AccountHolder> testList = [
            new AccountHolder{Id = 1, email = "contact@gooseribbon.com", password = "OpenDoor"},
            new AccountHolder{Id = 2, email = "sales@gooseribbon.com", password = "OpenGate"},
            new AccountHolder{Id = 3, email = "newsletter@gooseribbon.com", password = "OpenFilter"}
        ];

        mockRepo.Setup(worker => worker.FindAllAccounts()).Returns(testList);

        //Act
        List<AccountHolder> result = testService.FindAllAccounts().ToList();

        //Assert
        Assert.Contains(result, action => action.Id == 1);

    }

    [Fact]
    public void CreateNewAccount()
    {
       //Arrange
        Mock<IAccountHolderRepository> mockRepo = new();
        AccountHolderService testService = new(mockRepo.Object);

        List<AccountHolder> testList = [
            new AccountHolder{Id = 1, email = "contact@gooseribbon.com", password = "OpenDoor"},
            new AccountHolder{Id = 2, email = "sales@gooseribbon.com", password = "OpenGate"},
            new AccountHolder{Id = 3, email = "newsletter@gooseribbon.com", password = "OpenFilter"}
        ];

        AccountHolder workerAcc = new AccountHolder{Id = 10, email =  "Test", password = "Case"};

        mockRepo.Setup(worker => worker.CreateAccount(workerAcc))
        .Callback((AccountHolder a) => testList.Add(a))
        .Returns(workerAcc);

        //Act
        AccountHolder update = testService.CreateAccount(workerAcc);

        //Assert
        Assert.Contains(workerAcc, testList);

    }
}