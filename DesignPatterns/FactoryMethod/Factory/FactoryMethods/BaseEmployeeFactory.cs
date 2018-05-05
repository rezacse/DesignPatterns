using FactoryMethod.Managers;
using FactoryMethod.Models;

namespace FactoryMethod.Factory.FactoryMethods
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee Employee;

        protected BaseEmployeeFactory(Employee employee)
        {
            Employee = employee;
        }

        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = Create();
            Employee.Bonus = employeeManager.GetBonus();
            Employee.Pay = employeeManager.GetPay();
            return Employee;
        }
    }
}
