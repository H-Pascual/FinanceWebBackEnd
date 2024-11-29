namespace FinanceBackEnd.Core.Entities
{
    public class Portfolio
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public FinancialInstrument[] Items { get; set; }
    }
}
