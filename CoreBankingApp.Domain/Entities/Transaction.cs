namespace CoreBankingApp.Domain.Entities
{
    public class Transaction
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
    }
}
 