namespace FinanceBackEnd.Core.Entities
{
    public class BankOperation
    {
        public string Id { get; set; }
        public BankOperationType Type { get; set; } //Income, Bills
        public string Concept { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
    }
}
