namespace ConsoleApp1
{
    class Invoice
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        public Invoice(int id, string clientName, DateTime issueDate, decimal amount, bool isPaid)
        {
            Id = id;
            ClientName = clientName;
            IssueDate = issueDate;
            Amount = amount;
            IsPaid = isPaid;
        }
    }
}
