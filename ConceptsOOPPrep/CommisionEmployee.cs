namespace ConceptsOOPPrep
{
    public class CommisionEmployee : Employee
    {
        private float _commisionPercentaje;
        private decimal _sales;

        public float CommisionPercentaje
        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);
        }

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"% Commision.....: {CommisionPercentaje,16:P2}\n\t" +
                $"Sales...........: {Sales,15:C2}\n\t" +
                $"Salary..........: {GetValueToPay(),15:C2}";
        }

        public override decimal GetValueToPay()
        {
            return (decimal)CommisionPercentaje * Sales;
        }

        private float ValidateCommisionPercentaje(float value)
        {
            if (value > 0)
            {
                return value;
            }

            throw new ArgumentException("The commision percentaje must be a number greather than zero.");
        }

        private decimal ValidateSales(decimal value)
        {
            if (value >= 0)
            {
                return value;
            }

            throw new ArgumentException("The sales must be a positive number.");
        }
    }
}

