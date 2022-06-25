namespace BadBroker.WebApi.Data.Repositories
{
    public class PeriodRepository : IPeriodRepository
    {
        public async Task<string> GetHistoricalRates(DateTimeOffset stardate, DateTimeOffset endDate, CurrencyType currencyType)
        {
            throw new NotImplementedException();
        }
    }
}
