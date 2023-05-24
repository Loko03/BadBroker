using BadBroker.WebApi.Controllers.RequestHandlers;
using Microsoft.AspNetCore.Mvc;

namespace BadBroker.WebApi.Controllers
{
    [Route("api/v1")]
    [Route("rates")]
    [ApiController]
    public class BrokerController : ControllerBase
    {
        private readonly Func<BestRateRequestHandler> _bestRateRequestHander;
        
        public BrokerController(Func<BestRateRequestHandler> bestRateRequestHander)
        {
            _bestRateRequestHander= bestRateRequestHander;
        }        

        [HttpGet("best")]
        public IActionResult GetBestRates([FromQuery]BestRateRequest request)
        {
            var result = _bestRateRequestHander().Handle(request); 
            return Ok(result);
        }        
    }
}
