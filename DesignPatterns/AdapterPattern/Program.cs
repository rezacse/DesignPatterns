using AdapterPattern.Adapter;
using System;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEmployeeAdapter employeeAdapter = new EmployeeAdapter();
            var jsonResult = employeeAdapter.GetEmployeeList();
            Console.Write(jsonResult);
        }
    }
}
