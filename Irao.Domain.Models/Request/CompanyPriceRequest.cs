namespace Irao.Domain.Models.Request
{
    public class CompanyPriceRequest
    {
        public int CompanyId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}
