namespace ConceptsOOPPrep
{
    public class HourlyEmployee : Employee
    {
        private float _workingHours;
        private decimal _hourValue;

        public float WorkingHours
        {
            get => _workingHours;
            set => _workingHours = ValidateWorkingHours(value);
        }

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Working hours...: {WorkingHours,15:N2}\n\t" +
                $"Hour value......: {HourValue,15:C2}\n\t" +
                $"Salary..........: {GetValueToPay(),15:C2}";
        }

        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHours * HourValue;
        }

        private decimal ValidateHourValue(decimal value)
        {
            if (value > 0)
            {
                return value;
            }

            throw new ArgumentException("The hour value must be a number greather than zero.");
        }

        private float ValidateWorkingHours(float value)
        {
            if (value >= 0)
            {
                return value;
            }

            throw new ArgumentException("The working hours must be a positive number.");
        }
    }
}
