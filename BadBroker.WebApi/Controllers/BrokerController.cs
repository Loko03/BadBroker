using BadBroker.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BadBroker.WebApi.Controllers
{
    [Route("api/rates")]
    [ApiController]
    public class BrokerController : ControllerBase
    {
        IRatesService _ratesService;
        public BrokerController(IRatesService ratesService)
        {
            _ratesService = ratesService;
        }        

        [HttpGet("best")]
        public IEnumerable<string> GetBestRates(DateTime startDate, DateTime endDate, decimal moneyUsd)
        {

        }        
    }
}
