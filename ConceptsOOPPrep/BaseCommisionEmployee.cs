namespace ConceptsOOPPrep
{
    public class BaseCommisionEmployee : CommisionEmployee
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Salary;
        }

        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                $"Hired in........: {HireDate,15}\n\t" +
                $"% Commision.....: {CommisionPercentaje,16:P2}\n\t" +
                $"Sales...........: {Sales,15:C2}\n\t" +
                $"Base............: {Salary,15:C2}\n\t" +
                $"Salary..........: {GetValueToPay(),15:C2}";
        }
        private decimal ValidateSalary(decimal value)
        {
            if (value > 400000)
            {
                return value;
            }

            throw new ArgumentException("The salary is lower than minimun salary.");
        }
    }
}
