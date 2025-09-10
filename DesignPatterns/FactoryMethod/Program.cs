using FactoryMethod.Factory;
using FactoryMethod.Models;

var employee = new Employee
{
    EmployeeType = EmployeeType.Permanent
};

var factory = new EmployeeManagerFactory().GetEmployeeManager(employee);
factory.ApplySalary();

//
employee = new Employee
{
    EmployeeType = EmployeeType.Contract
};
factory = new EmployeeManagerFactory().GetEmployeeManager(employee);
factory.ApplySalary();