using Irao.Domain.Models.Trade;
using Irao.Domain.Repositories;
using Irao.Infrastructure.Store.Auth;
using Microsoft.EntityFrameworkCore;

namespace Irao.Infrastructure.Repositories
{
    public class TradeRepository : ITradeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TradeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task UpdatePrice(Company company)
        {
            _dbContext.Update(company);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Company> GetMarket(int companyId)
        {
            var res = await _dbContext.Companies
                .Where(x => x.Id == companyId)
                .FirstOrDefaultAsync();

            return res;
        }

        public async Task<IEnumerable<Company>> GetCurrentlyCompaniesPrice()
        {
            return await _dbContext.Companies
                .Include(x => x.Market)
                .ToListAsync();
        }
    }
}