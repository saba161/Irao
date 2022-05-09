namespace Irao.Domain.Models.Trade
{
    public class Market
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}