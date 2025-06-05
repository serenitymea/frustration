namespace ConsoleApp1
{
    class InvoiceRepository
    {
        public List<Invoice> Invoices { get; }

        public InvoiceRepository()
        {
            Invoices = new List<Invoice>
            {
            new Invoice(1, "John William Smith", new DateTime(2025, 1, 5), 1250.50m, true),
            new Invoice(2, "Emily Johnson", new DateTime(2025, 1, 15), 2400.00m, false),
            new Invoice(3, "Michael Brown", new DateTime(2025, 2, 1), 990.99m, true),
            new Invoice(4, "Sophia Davis", new DateTime(2025, 2, 10), 430.75m, false),
            new Invoice(5, "William Wilson", new DateTime(2025, 2, 20), 3150.00m, true),
            new Invoice(6, "Olivia Martinez", new DateTime(2025, 3, 3), 875.60m, false),
            new Invoice(7, "James Anderson", new DateTime(2025, 3, 12), 1490.90m, true),
            new Invoice(8, "Isabella Thomas", new DateTime(2025, 3, 25), 210.00m, false),
            new Invoice(9, "Liam Taylor", new DateTime(2025, 4, 5), 560.00m, true),
            new Invoice(10, "Mia Moore", new DateTime(2025, 4, 10), 780.30m, true),
            new Invoice(11, "Noah Jackson", new DateTime(2025, 4, 15), 3100.00m, false),
            new Invoice(12, "Emma Abigail White", new DateTime(2025, 4, 20), 650.50m, true),
            new Invoice(13, "Lucas Harris", new DateTime(2025, 5, 1), 1210.75m, false),
            new Invoice(14, "Ava Martin", new DateTime(2025, 5, 5), 1700.00m, true),
            new Invoice(15, "Elijah Thompson", new DateTime(2025, 5, 10), 850.45m, true),
            new Invoice(16, "Charlotte Garcia", new DateTime(2025, 5, 15), 1350.20m, false),
            new Invoice(17, "Benjamin William Martinez", new DateTime(2025, 5, 18), 2200.00m, true),
            new Invoice(18, "Amelia Robinson", new DateTime(2025, 5, 20), 430.00m, false),
            new Invoice(19, "Henry Jackson Clark", new DateTime(2025, 5, 22), 980.00m, true),
            new Invoice(20, "Evelyn Rodriguez", new DateTime(2025, 5, 25), 1150.90m, false),
            new Invoice(21, "Alexander Lewis", new DateTime(2025, 5, 26), 700.00m, true),
            new Invoice(22, "Harper Lee", new DateTime(2025, 5, 27), 1430.30m, false),
            new Invoice(23, "Daniel Walker", new DateTime(2025, 5, 28), 1020.20m, true),
            new Invoice(24, "Ella Hall", new DateTime(2025, 5, 29), 230.00m, false),
            new Invoice(25, "Matthew Allen", new DateTime(2025, 5, 30), 1575.00m, true),
            new Invoice(26, "Abigail Young", new DateTime(2025, 6, 1), 680.75m, true),
            new Invoice(27, "Jackson King", new DateTime(2025, 6, 2), 800.00m, false),
            new Invoice(28, "Emily Wright", new DateTime(2025, 6, 3), 1920.10m, true),
            new Invoice(29, "Sebastian Scott", new DateTime(2025, 6, 4), 1325.00m, true),
            new Invoice(30, "Scarlett Green", new DateTime(2025, 6, 5), 410.50m, false),
            };
        }
    }
}
