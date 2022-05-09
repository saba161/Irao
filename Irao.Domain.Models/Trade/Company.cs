namespace Irao.Domain.Models.Trade
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Market Market { get; set; }
    }
}