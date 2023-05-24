namespace BadBroker.WebApi.Controllers.RequestHandlers
{
    public class BestRateRequestHandler : IRequestHandler<BestRateRequest,IEnumerable<BestRateResponse>>
    {
        public BestRateRequestHandler()
        {

        }

        public IEnumerable<BestRateResponse> Handle(BestRateRequest request)
        {
            return new List<BestRateResponse>();
        }
    }

    public interface IRequestHandler<TRequest,TResponse> 
        where TRequest : class 
        where TResponse : class
    {
        TResponse Handle(TRequest request);
    }

    public class BestRateRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
    }

    public class BestRateResponse
    { }
}
