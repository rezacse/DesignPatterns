using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;

namespace Flyweight.FlyweightFactory
{
    public sealed class EmployeeBonusFactory
    {


        #region singleton
        private static readonly Lazy<EmployeeBonusFactory> Instance = new Lazy<EmployeeBonusFactory>(() => new EmployeeBonusFactory());
        private EmployeeBonusFactory()
        {

        }

        public static EmployeeBonusFactory GetInstance => Instance.Value;
        #endregion

        private readonly Dictionary<string, IEmployeeBonus> _employeeBonusObjects = new Dictionary<string, IEmployeeBonus>();
        public int TotalObject => _employeeBonusObjects.Count;
        public IEmployeeBonus GetEmployeeBonusObject(string employeeType)
        {
            if (_employeeBonusObjects.ContainsKey(employeeType))
                return _employeeBonusObjects[employeeType];

            switch (employeeType)
            {
                case "Permanent":
                    _employeeBonusObjects.Add(employeeType, new PermanentEmployeeBonus());
                    break;
                case "Contract":
                    _employeeBonusObjects.Add(employeeType, new ContractEmployeeBonus());
                    break;
                default:
                    throw new ArgumentException("Unknown employee type");
            }

            return _employeeBonusObjects[employeeType];
        }
    }
}
