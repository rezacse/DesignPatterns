namespace FactoryMethod.Managers
{
    public class ContractEmployeeManager : IEmployeeManager

    {
        public double GetBonus()
        {
            return 10;
        }

        public double GetPay()
        {
            return 100;
        }

        public double GetMedicalAllowance()
        {
            return 5;
        }
    }
}
