using AdapterPattern.Adaptee;
using Newtonsoft.Json;

namespace AdapterPattern.Adapter
{
    internal class EmployeeAdapter : IEmployeeAdapter
    {
        public string GetEmployeeList()
        {
            var employeeManager = new EmployeeManager();
            var employees = employeeManager.GetEmployees();

            var jsonResult = JsonConvert.SerializeObject(employees, Formatting.Indented);

            return jsonResult;
        }
    }
}