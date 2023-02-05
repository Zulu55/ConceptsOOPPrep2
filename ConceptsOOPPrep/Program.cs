using ConceptsOOPPrep;

try
{
    SalaryEmployee salaryEmployee = new()
    {
        BornDate = new(1974, 9, 23),
        FirstName = "Juan",
        HireDate = new(2022, 8, 29),
        Id = 1010,
        IsActive = true,
        LastName = "Zuluaga",
        Salary = 1200000
    };
    HourlyEmployee hourlyEmployee = new()
    {
        BornDate = new(1981, 1, 11),
        FirstName = "Ledys",
        HireDate = new(2012, 2, 6),
        HourValue = 46000,
        WorkingHours = 48,
        Id = 2020,
        IsActive = true,
        LastName = "Bedoya"
    };
    CommisionEmployee commisionEmployee = new()
    {
        BornDate = new(1984, 11, 5),
        CommisionPercentaje = 0.05f,
        FirstName = "Jazmin",
        HireDate = new(2020, 4, 12),
        Id = 3030,
        IsActive = true,
        LastName = "Palacios",
        Sales = 230000000
    };
    BaseCommisionEmployee baseCommisionEmployee = new()
    {
        BornDate = new(1990, 1, 15),
        CommisionPercentaje = 0.025f,
        FirstName = "Carolina",
        HireDate = new(2022, 12, 12),
        Id = 4040,
        IsActive = true,
        LastName = "Cruz",
        Sales = 89000000,
        Salary = 450000
    };

    Employee[] employees = new Employee[] 
    { 
        salaryEmployee, 
        hourlyEmployee, 
        commisionEmployee, 
        baseCommisionEmployee
    };

    decimal total = 0;
    foreach (Employee employee in employees)
    {
        Console.WriteLine(employee);
        total += employee.GetValueToPay();
    }

    Console.WriteLine($"                          ===============");
    Console.WriteLine($"TOTAL PAYROLL...........: {total,15:C2}");

    Invoice[] invoices = new Invoice[]

    {
        new Invoice { Id = 1001, Description = "Paper", Price = 25000, Quantity = 12 },
        new Invoice { Id = 1002, Description = "Chair", Price = 1240000, Quantity = 2 },
        new Invoice { Id = 1003, Description = "Computer", Price = 6300000, Quantity = 3 },
    };

    foreach (var invoice in invoices)
    {
        Console.WriteLine(invoice);
        total += invoice.GetValueToPay();
    }

    Console.WriteLine($"                          ===============");
    Console.WriteLine($"GENERAL TOTAL...........: {total,15:C2}");
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

