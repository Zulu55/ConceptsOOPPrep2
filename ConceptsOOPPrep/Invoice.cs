namespace ConceptsOOPPrep
{
    public class Invoice : IPay
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public float Quantity { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                $"Quantity........: {Quantity,15:N2}\n\t" +
                $"Price...........: {Price,15:C2}\n\t" +
                $"Value to pay....: {GetValueToPay(),15:C2}";
        }
    }
}
