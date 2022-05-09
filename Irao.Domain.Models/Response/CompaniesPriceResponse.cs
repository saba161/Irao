namespace Irao.Domain.Models.Response
{
    public class CompaniesPriceResponse
    {
        public List<CompanyDetails> Date { get; set; }
    }

    public class CompanyDetails
    {
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string MarketName { get; set; }
    }
}