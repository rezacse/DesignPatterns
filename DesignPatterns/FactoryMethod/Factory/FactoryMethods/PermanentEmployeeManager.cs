using FactoryMethod.Managers;
using FactoryMethod.Models;

namespace FactoryMethod.Factory.FactoryMethods
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee)
            : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            Employee.HomeAllowance = manager.GetHomeAllowance();
            return manager;
        }
    }
}
