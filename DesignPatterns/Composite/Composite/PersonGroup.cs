using Composite.Component;
using System.Collections.Generic;
using System.Linq;

namespace Composite.Composite
{
    public class PersonGroup : IPerson
    {
        public string GroupName { get; set; }
        public List<IPerson> Members;


        public PersonGroup()
        {
            Members = new List<IPerson>();
        }

        public int Amount
        {
            get
            {
                return Members.Sum(m => m.Amount);
            }
            set
            {
                var eachPerson = value / Members.Count;
                var leftAmount = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Amount += eachPerson + leftAmount;
                    leftAmount = 0;
                }
            }
        }

        public void PrintStatus()
        {
            foreach (var member in Members)
            {
                member.PrintStatus();
            }
        }
    }
}
