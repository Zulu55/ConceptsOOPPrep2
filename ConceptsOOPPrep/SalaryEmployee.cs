namespace ConceptsOOPPrep
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;

        public decimal Salary 
        {
            get => _salary;
            set => _salary = ValidateSalary(value); 
        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Salary..........: {GetValueToPay(),15:C2}";
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value > 1000000)
            {
                return value;
            }

            throw new ArgumentException("The salary is lower than minimun salary.");
        }
    }
}
