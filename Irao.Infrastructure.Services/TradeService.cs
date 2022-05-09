using Irao.Domain.Models.Request;
using Irao.Domain.Models.Response;
using Irao.Domain.Models.Trade;
using Irao.Domain.Repositories;
using Irao.Domain.Services;

namespace Irao.Infrastructure.Services
{
    public class TradeService : ITradeService
    {
        private readonly ITradeRepository _tradeRepository;

        public TradeService(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public async Task UpdatePrice(CompanyPriceRequest request)
        {
            Company company = new Company
            {
                Id = request.CompanyId,
                Price = request.Price,
                Name = request.Name
            };
            await _tradeRepository.UpdatePrice(company);
        }

        public async Task<CompaniesPriceResponse> GetCurrentlyCompaniesPrice()
        {
            CompaniesPriceResponse resp = new CompaniesPriceResponse();
            IEnumerable<Company> company = await _tradeRepository.GetCurrentlyCompaniesPrice();

            resp.Date = company.Select(x => new CompanyDetails
            {
                Price = x.Price,
                MarketName = x.Market.MarketName,
                CompanyName = x.Name
            }).ToList();
            return resp;
        }
    }
}