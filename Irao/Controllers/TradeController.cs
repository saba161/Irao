using Irao.Domain.Models.Request;
using Irao.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Irao.App.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TradeController : ControllerBase
    {
        private readonly ITradeService _tradeService;
        private readonly ILogger<TradeController> _logger;

        public TradeController(ITradeService tradeService, ILogger<TradeController> logger)
        {
            _logger = logger;
            _tradeService = tradeService;
        }

        [HttpGet("api/GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var result = await _tradeService.GetCurrentlyCompaniesPrice();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "error");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("api/UpdatePrice")]
        public async Task<IActionResult> UpdatePrice(CompanyPriceRequest request)
        {
            try
            {
                await _tradeService.UpdatePrice(request);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "error");
                return BadRequest(ex.Message);
            }
        }
    }
}