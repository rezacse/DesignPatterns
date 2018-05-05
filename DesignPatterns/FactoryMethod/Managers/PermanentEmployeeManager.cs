namespace FactoryMethod.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 20;
        }

        public double GetPay()
        {
            return 200;
        }

        public double GetHomeAllowance()
        {
            return 10;
        }
    }
}
