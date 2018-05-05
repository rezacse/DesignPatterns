namespace FactoryMethod.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public double Pay { get; set; }
        public double Bonus { get; set; }
        public double MedicalAllowance { get; set; }
        public double HomeAllowance { get; set; }
    }
}
