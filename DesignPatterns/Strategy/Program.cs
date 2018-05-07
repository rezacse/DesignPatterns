﻿using FactoryMethod.Models;
using Strategy.BonusCalculator;
using Strategy.Factories;
using Strategy.Models;
using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Permanent Employee",
                    Salary = 5000,
                    EmployeeType = EmployeeType.Permanent
                },
                new Employee
                {
                    Name = "Contract Employee",
                    Salary = 5000,
                    EmployeeType = EmployeeType.Contract
                }
            };

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Strategy With Constructor Passing and Factory Methods");
            Console.WriteLine("------------------------------------------------------");

            foreach (var employee in employees)
            {
                IEmployeeBonusCalculator employeeBonusCalculator = new EmployeeBonusManagerFactory().GetEmployeeManager(employee);
                var salaryCalculator = new EmployeeSalaryCalculatorService(employeeBonusCalculator);
                Console.WriteLine($"Name: {employee.Name}, Total Salary: {salaryCalculator.CalculateSalary(employee)}");
                Console.WriteLine("------------------------------------------------------");
            }

            //with delegate passing
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Strategy With Delegate Passing");
            Console.WriteLine("------------------------------------------------------");

            var employeeSalaryCalculator = new EmployeeSalaryCalculatorService();

            foreach (var employee in employees)
            {
                var employeeBonusDelegate = new EmployeeBonusDelegateFactory().GetEmployeeDelegate(employee);
                var totalSalary = employeeSalaryCalculator.CalculateSalary(employees[0], employeeBonusDelegate);
                Console.WriteLine($"Name: {employees[0].Name}, Total Salary: {totalSalary}");
                Console.WriteLine("------------------------------------------------------");
            }

            Console.ReadKey();
        }

    }
}
