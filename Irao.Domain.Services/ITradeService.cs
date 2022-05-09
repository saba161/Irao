using Irao.Domain.Models.Request;
using Irao.Domain.Models.Response;
using Irao.Domain.Models.Trade;

namespace Irao.Domain.Services
{
    public interface ITradeService
    {
        Task<CompaniesPriceResponse> GetCurrentlyCompaniesPrice();
        Task UpdatePrice(CompanyPriceRequest request);
    }
}