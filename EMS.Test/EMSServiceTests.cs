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
}