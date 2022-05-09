using Irao.Domain.Models.Request;
using Irao.Domain.Models.Trade;

namespace Irao.Domain.Repositories
{
    public interface ITradeRepository
    {
        Task<IEnumerable<Company>> GetCurrentlyCompaniesPrice();
        Task UpdatePrice(Company company);
        Task<Company> GetMarket(int companyId);
    }
}