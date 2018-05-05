using FactoryMethod.Managers;
using FactoryMethod.Models;

namespace FactoryMethod.Factory.FactoryMethods
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee)
            : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            Employee.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
